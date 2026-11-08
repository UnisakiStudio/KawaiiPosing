# Kawaii Posing development

The user requested multilingual work on `codex/v3.2.0-localization`, merging released
`main` through 3.1.2. Use this primary checkout. Before any commit verify author and
committer are `UnisakiStudio <unisaki.studio@gmail.com>` and retain Git guards.

Every feature/fix must include its display translations and terminology check, not
just Japanese and English. Read `../PosingSystem/Tools/Localization/README.md` and
update the shared authoritative translation tables. Include Inspector titles,
ON/OFF descriptions, tooltips, dialogs, native menus, generated menus, setup and
guides. Run the shared offline coverage audit and relevant Unity checks. Preserve
IDs, paths, parameters, asset references and custom names. Pose names are translated
as a complete set per language. Never count fallback as translation or silently
send text to external translation services. Public publication needs new approval.
