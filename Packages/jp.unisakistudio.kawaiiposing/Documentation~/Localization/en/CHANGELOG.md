# Changelog

## [3.2.0] - Unreleased

### Added

- Added thirty-language display for the Inspector, editing actions, installation dialogs, standard pose names and generated VRChat menus.
- Unified language selection for the Inspector and in-game menu. The default follows the computer's language, and the last choice is reused in other projects belonging to the same OS user.
- README, changelog and offline manuals can be opened in the selected language.
- Prepared display names for all 128 standard poses and feature descriptions using the established terminology.

### Compatibility

- Existing avatar settings, custom names, asset references, parameter identifiers and license storage are preserved.

## [3.1.2] - 2026-11-09

- Head lock can now be toggled under Settings > Automatic head lock when supine in the EX menu even when Foot Height is disabled. Avatars where the item disappeared in earlier versions regain it when built after updating.
- Added support for Unisaki Posing System 3.1.2. Fixed the face remaining tilted upward after getting up from prone when Reduce pose distortion from head rotation is enabled.

Update Kawaii Posing Tool to 3.1.2 in ALCOM / VCC. Unisaki Posing System 3.1.2 is also required. If you previously used prebuilds, click Update prebuild, save the scene, then build and upload the avatar again.

## [3.1.1] - 2026-11-08

- Enabled Floor Height and Roll Over entries now appear under Settings in the VRChat EX menu even when Mirror is disabled.
- Correct roll-over settings are carried over for Legs Out, Relaxed and One Knee Up even if an older version's poses were reordered, deleted or renamed. Fully unpacked objects are supported when the original pose can be identified. Custom poses, explicitly disabled roll-over settings and replacement side-lying motions are preserved.
- Fixed a brief prone pose when selecting an avatar in VRChat. Also fixed a brief supine pose when jumping with only a prone pose selected. Jump switching can be disabled under Features > Convenience > Switch lying posture by jumping; it defaults to on.
- If an update breaks a reference to the shared posing Animator Controller, a warning is shown and the Controller is rebuilt from settings when recovery is possible. References to Controllers shared by multiple avatars are preserved.
- The tool-addition menu now places the official Prefab even if you saved another 可愛いポーズ Prefab with the same name.
- If the required 添い寝ツール integration product is missing when Add 添い寝ツール is selected, guidance identifies the product to install first.

Update both Kawaii Posing Tool and Unisaki Posing System to 3.1.1 in ALCOM / VCC. If you previously used prebuilds, click Update prebuild on the scene's 可愛いポーズ object and save the scene. Build and upload the avatar again to apply changes in VRChat.

## [3.1.0] - 2026-11-07

- 53 of the 85 included poses now use IK to fit limb positions to the avatar's body.
- The back-lying poses Legs Out, Relaxed and One Knee Up support head-tilt roll over.
- Photo Mode adjusts avatar position and rotation, with optional synchronization and visibility of your own head during photography.
- Floor Height moves the whole body up/down by 3m, separately from Foot Height.
- Added breathing motion, suppression of default idle sway and reduction of neck-orientation pose distortion.
- The Inspector shows enabled features and parameter usage. Added pose search, batch addition, reordering and quick Scene previews.
- Sped up standing/crouching/sitting switching in desktop mode.
- Improved stale-prebuild warnings, Inspector scrolling overhead and long stalls during generated-data cleanup.
- Added support for Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Open beta (2026-11-05)

- Began open-beta distribution through GitHub Releases and VPM. 53 of the 85 included poses use IK to fit limbs to the avatar's body.
- Added shared package 3.1.0-beta.2 support, improving post-prebuild change indicators, Inspector scrolling overhead and stalls during generated-data cleanup.

## [3.1.0-beta.1] - Open beta (2026-11-04)

- Added support for Unisaki Posing System 3.1.0-beta.1.
- Changed normal desktop posture switching to a single-evaluation approach for regular builds and prebuilds; VR and special conditions retain existing paths.
- Prebuilds from alpha.3 or earlier are recognized as needing an update.
- Preserved the viewpoint when changing floor height during photography, then restored the latest floor height when photography ends.
- Included improvements through alpha.3 to automatic import, imported-motion adjustments and generated-Controller management.

## [3.1.0-alpha.2] - Closed test (2026-10-26)

### Fixed and changed

- Updated the shared posing system to 3.1.0-alpha.2 with debugging fixes.
- Expanded Floor Height to 3m up/down, with 50% as the original height and default.
- Photo/Floor Height correction now also covers default/custom motions when no tool pose is selected.
- Fixed manual correction, identically named poses, initial poses, old presets' roll-over settings and related issues.

## [3.1.0-alpha.1] - Before publication

### Added

- Added automatic limb adjustment (IK) to fit the avatar's body.
- Added overall/per-pose IK ON/OFF and baking into adjustment animations.
- Added head-tilt roll over for the back-lying Legs Out, Relaxed and One Knee Up poses.
- Added per-pose roll-over settings and side-lying animation assignments.
- Added Photo Mode with forward movement and rotation.
- Added optional Photo Mode synchronization: 0 bit locally, 16 bit synchronized.
- Added an option to keep your avatar's head visible during Photo Mode.
- Added Floor Height to raise the whole body, including the head.
- Added breathing motion, intensity settings and an in-game ON/OFF menu.
- Added suppression of VRChat's default idle sway.
- Added reduction of pose distortion caused by neck-orientation differences.
- Added prevention of backward knee bending and minimum knee angle settings.
- Added per-feature ON/OFF and ExpressionParameters usage display.
- Added quick Scene previews, pose search, batch addition and destination-order selection.
- Added changelogs in the Inspector.

### Changed

- Organized the Inspector into Features, Poses and Avatar Setup tabs.
- Reorganized breathing details, custom-motion imports and presets.
- Reduced duplicated animations generated for foot-height adjustment.
- Added confirmation for pose-image updates and grouped warning settings under Check settings.
- Removed the new-installation 8bit menu in favor of feature selection on regular Prefabs, preserving existing references.
- Added Unisaki Posing System 3.1.0-alpha.1 support and raised the minimum VRChat Avatars SDK version to 3.10.4.

### Fixed

- Fixed pose-name input moving to another pose and details closing during reordering.
- Fixed overlapping/displaced previews and errors on some avatars.
- Fixed warning/prebuild status updates after settings changes and some build errors.

## [3.0.13] - 2026-09-22
- Updated to PosingSystem 3.0.17, fixing horizontal pose offsets when uniformly scaling an entire avatar.
- Added settings to ignore automatic-stepping, missing-prebuild and changed-settings warnings individually or together.
- Fixed inappropriate one-shot animations being imported during manual locomotion imports.

## [3.0.12] - 2026-09-15
- Added an avatar preset (ルリエ).

## [3.0.11] - 2026-09-09
- Added avatar presets (メルヴィ, ミダリス).
- Fixed motion replacement in the うらら preset.

## [3.0.10] - 2026-08-31
- Updated to PosingSystem 3.0.11, fixing prebuild failures with the latest NDMF and exceptions while displaying errors.

## [3.0.9] - 2026-08-29
- Updated to PosingSystem 3.0.10, reducing preset-loading and Hierarchy icon-checking overhead.
- Fixed prebuild errors with multiple posing systems on one avatar.

## [3.0.8] - 2026-08-26
- Updated to PosingSystem 3.0.9, fixing `Avatar is null` failures in Play mode when NDMF invalidated a preview Avatar.

## [3.0.7] - 2026-08-18
- Updated to PosingSystem 3.0.8, fixing potentially invalid pose data when height correction is reapplied.

## [3.0.6] - 2026-08-12
- Added avatar presets (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Added avatar presets (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Added avatar presets (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Improved license installation and removal features.

## [3.0.2] - 2026-01-04
- Fixed license processing on Mac and Linux.

## [3.0.1] - 2025-12-28
- Added avatar presets (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Added prebuilds.
- Added animation adjustment.
- Added presets.
- Enabled adding the tool to a project through a unitypackage.
- Added avatar presets (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Resolved compatibility issues with some gimmicks.

## [2.2.4] - 2025-04-04
- Fixed poses no longer changing with some avatars and ModularAvatar versions.

## [2.2.3] - 2025-03-13
- Fixed incorrect motions on some avatars, including 森羅's jump.
- Fixed the initial Disable Gestures setting sometimes being incorrect.

## [2.2.2] - 2025-03-06
- Fixed errors in some environments.

## [2.2.1] - 2025-02-05
- Fixed Unity crashes.
- Added the version to the tool name shown in the NDMF Console.

## [2.2.0] - 2025-02-02
- Added a setting to disable gestures and use the animation's hand shapes.
- Added hand-shape data to every pose.

## [2.1.6] - 2025-02-02
- Fixed poses breaking when combined with some tools.
- Fixed errors with certain settings.

## [2.1.5] - 2024-12-10
- Resolved conflicts with some gimmicks.
- Added a button to remove the Unitypackage edition.
- Removed integration Prefabs for 三点だいしゅきツール following its VCC release.

## [2.1.4] - 2024-12-08
- Fixed errors with some avatars.
- Fixed foot lock becoming unavailable because of gimmick/avatar conflicts.
- Fixed avatar posture reverting to VRChat's default in desktop mode.

## [2.1.3] - 2024-12-01
- Fixed poses no longer changing when used with avatars or gimmicks that assign the wrong type to VRMode.
- Added NDMF-Console reporting for parameter-type conflicts between gimmicks.

## [2.1.2] - 2024-12-01
- Added NDMF-Console guidance because errors in other tools can cause Unisaki Posing System errors during avatar builds.
- Fixed build errors with some avatars.
- Improved behavior immediately after loading an avatar.
- The avatar's original locomotion processing is now removed because it prevents operation on some avatars.

## [2.1.1] - 2024-11-20
- Fixed builds becoming impossible.

## [2.1.0] - 2024-11-20
- Resolved feet and hips sinking into the ground in desktop mode so poses display correctly.
- Added posture changes independent of head height.
- Added an option to skip icon generation for Quest avatar uploads.
- Added several warnings for avatar issues.
- Resolved lock conflicts with AFK and other tools' arm-lock gimmicks.
- Added automatic head lock while supine.
- Changed ExpressionsMenu: pose selection is grouped into a folder and lock controls moved to the top level.

## [2.0.0] - 2024-11-14
### Fixed
- Converted to a VPM package for VCC support.
- Fixed the 8bit edition consuming 17bit.

## [1.15.0] - 2024-11-04
### Fixed
- Fixed errors and bugs.

## [1.14.0] - 2024-07-05
### Fixed
- Fixed issues when using VRCFury.

## [1.13.0] - 2024-04-11
### Fixed
- Added integration settings for ごろ寝システムEX.

## [1.12.0] - 2024-03-31
### Fixed
- Fixed the tool being unavailable in some ExMenu states.
- Added Mirror to settings.
- Fixed the cat pose.
- Added 5 side-lying poses.

## [1.11.0] - 2024-03-12
### Fixed
- Fixed incorrect poses when head position was high.

## [1.10.0] - 2024-03-10
### Fixed
- Added standing functionality and 15 poses.
- Fixed feet moving unintentionally with some avatars/environments.
- Added the ExpressionParameters 8bit edition.

## [1.9.0] - 2024-03-05
### Fixed
- Fixed feet moving unintentionally on some avatars.
- Unified WriteDefaults.
- Added 7 crouching and 8 sitting poses.

## [1.8.0] - 2024-02-25
### Fixed
- Fixed upload failures when using ModularAvatar1.9.0 or later.
- ModualrAvatar1.9.0 or later is now required.

## [1.7.0] - 2024-02-23
### Fixed
- Added customizable head-height thresholds for each posture.
- Fixed incorrect postures/feet when jumping and in similar situations on some avatars.
- Reduced ExpressionParameter usage from 54 to 16bit.

## [1.6.0] - 2024-02-20
### Fixed
- Fixed sitting becoming unavailable in VR mode.

## [1.5.0] - 2024-02-18
### Fixed
- Sitting poses can now be used in desktop mode even with C pressed.

## [1.4.0] - 2024-02-17
### Fixed
- Fixed 添い寝 integration being unavailable without 三点だいしゅき integration.
- Fixed feet becoming stuck when jumping.

## [1.3.0] - 2024-02-16
### Fixed
- Fixed an abnormally large number of VRCContactSender/Receiver components being configured.

## [1.2.0] - 2024-02-16
### Fixed
- Fixed build errors on upload.

## [1.1.0] - 2024-02-15
### Fixed
- Fixed incorrect defaults when multiple Prefabs were used.
- Corrected the 可愛い座り integration settings.

## [1.0.0] - 2024-02-14
### Released
