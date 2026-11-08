"""Read-only documentation gate usable in each product checkout independently."""
from pathlib import Path
import hashlib
import json
import re
import sys

ROOT=Path(__file__).resolve().parents[2]
EXPECTED={'ja','en','fr','it','zh-Hans','zh-Hant','ko','th','de','es','pt','pt-BR','ru','uk','pl','nl','sv','da','fi','nb','cs','tr','id','vi','hi','bn','ta','te','ar','he'}

def digest(text): return hashlib.sha256(text.encode('utf-8')).hexdigest()

def canonical(text):
    return re.sub(r'\n<!-- localization-navigation:start -->.*?<!-- localization-navigation:end -->\n?', '', text.replace('\r\n','\n'), flags=re.S).strip()

def check(root=ROOT):
    manifests=list((root/'Packages').glob('*/Documentation~/Localization/manifest.json'))
    if len(manifests)!=1: return ['Expected one complete documentation manifest']
    path=manifests[0]; manifest=json.loads(path.read_text(encoding='utf-8-sig')); errors=[]
    if set(manifest['locales'])!=EXPECTED or not manifest.get('full_30_languages'): errors.append('All 30 languages are required')
    for relative,expected in manifest['sources'].items():
        source=root/relative
        if not source.is_file() or digest(canonical(source.read_text(encoding='utf-8-sig')))!=expected:
            errors.append('Documentation source changed without translation review: '+relative)
    for relative,expected in manifest['files'].items():
        generated=root/relative
        if not generated.is_file() or digest(generated.read_text(encoding='utf-8-sig').replace('\r\n','\n'))!=expected:
            errors.append('Generated documentation missing or changed: '+relative)
    for locale in EXPECTED:
        for name in ('README','CHANGELOG','UserGuide'):
            for extension in ('md','html'):
                relative=(path.parent/locale/(name+'.'+extension)).relative_to(root).as_posix()
                if relative not in manifest['files']: errors.append('Missing document coverage: '+relative)
    return errors

if __name__=='__main__':
    errors=check()
    for error in errors: print(error)
    print('Documentation gate:', 'FAIL' if errors else 'PASS')
    sys.exit(bool(errors))
