using UnityEditor;
using jp.unisakistudio.posingsystemeditor;

namespace jp.unisakistudio.kawaiiposingeditor
{
    // This product's own translations (product name, its pose names and captions) are
    // generated into Editor/Localization/translations.json from Tools/Localization in
    // this repository. Shared text and the lookup itself belong to the Posing System.
    [InitializeOnLoad]
    internal static class KawaiiPosingLocalization
    {
        internal const string CatalogPath = "Packages/jp.unisakistudio.kawaiiposing/Editor/Localization/translations.json";
        static KawaiiPosingLocalization() => PosingSystemLocalization.RegisterProductCatalog(CatalogPath);
    }
}
