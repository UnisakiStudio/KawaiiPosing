# Kawaii Posing Tool

A VRChat pose-locking tool for cute sitting and lying poses with three-point tracking or desktop mode. Includes 85 poses: 15 standing, 20 crouching, 17 sitting, 16 front-lying and 17 back-lying.

This README covers v3.2.0, currently in development. A release date has not been set. Check the installed version at the top of the Inspector.

- [BOOTH product page](https://yunisaki.booth.pm/items/5479202)
- [Changelog](CHANGELOG.md)

## Display language and offline documentation

Choose a display language with Language / 言語 at the top of the Inspector. One selection controls both the Inspector and generated VRChat menu. Re-upload the avatar to change its in-game language.

Without a saved choice, the tool follows the computer's language and uses English for unsupported languages. This works on Windows, macOS and Linux. The last selection is saved in EditorPrefs and reused in other projects belonging to the same OS user on this computer. An explicit selection already saved on an avatar is preserved. Preferences do not sync to other computers. License storage is unchanged.

Choose a README, changelog or manual from the bundled [language index](../index.html). The Inspector's Manual and View changelog also follow the selected language. Original agreements and reference translations remain separately available.

## Main features

- Photo Mode: move the avatar up to 3m forward and adjust its rotation. Uses 0 bit locally, or 16 bit to show position and rotation to others.
- Head visibility during photography: prevent your nearby avatar's head from disappearing specifically during Photo Mode.
- Floor Height: move the whole body, including the head, up/down by 3m. 50% is the original height and default, 0% is 3m below and 100% is 3m above. This is separate from Foot Height, which moves the feet side while preserving head position.
- Roll Over: tilt your head to roll left/right in supported lying poses.
- Breathing: add breathing motion to the chest and other parts, with None, Weak, Medium, Strong, Rapid and Custom settings for each posture category.
- Disable VRChat idle sway: suppress default idle sway while retaining the tool's breathing and other custom motions.
- Reduce pose distortion from head rotation: reduce distortion when releasing head lock if the neck orientation differs from the original pose.
- Feature selection: include only the required in-game menu features and check ExpressionParameters usage in the Inspector.
- Pose search, batch addition and reordering: search across categories, load multiple clips and select destination order.
- Quick Scene previews: use Preview in the pose list to inspect the posture in place.

- Automatic limb adjustment (IK): fit supported poses' limb positions to the avatar's body. Includes per-pose ON/OFF and baking the result into adjustment animations.

### Roll over with the included poses

The back-lying poses Legs Out, Relaxed and One Knee Up include side-lying settings for roll over. Their rolls are based respectively on 横向き寝, Nap and Cat Nap.

Enable Features > Menu features > Roll Over and upload. In VRChat, select a supported pose and Roll Over. Release head lock before use.

To configure it yourself, enable Poses > Details > Enable roll over and assign an animation to Sideways roll-over pose. Normal MotionTime settings are unavailable for a pose using Roll Over.

### Fitting poses to body shape

The included automatic limb adjustment is available, although not every pose needs IK. Use Enable automatic limb adjustment in the animation adjustment window for the overall setting and Enable IK for this pose for individual poses.

Bake IK into adjustments writes the current automatic result to a new adjustment animation and disables IK for the pose, allowing further manual work. It is available when overall and per-pose automatic adjustment are enabled and applicable IK settings exist.

Avatar Setup also provides Prevent reverse knee bending and its detailed Minimum knee bend (degrees) setting.

## Installation

1. Download the files from the product page at the store where you purchased it.
2. Import the bundled 可愛いポーズツール.unitypackage into Unity to register the license and package repositories.
3. In VCC or ALCOM, add Kawaii Posing Tool and Modular Avatar to your Unity project. The shared Unisaki Posing System and NDMF are also installed as dependencies.
4. Right-click the target avatar in the Hierarchy and choose Unisaki Studio > Add Kawaii Posing.
5. Select the added 可愛いポーズ object inside the avatar and configure the desired features and poses in the Inspector.
6. Upload the avatar normally.

Requires Unity 2022.3, VRChat Avatars SDK 3.10.4 or later, Modular Avatar 1.x version 1.15.1 or later, and NDMF 1.x version 1.14.0 or later. Update the required packages together in VCC or ALCOM.

## Updating from an earlier version

Update this product and Unisaki Posing System together. Existing tool settings are carried over. Check enabled features and ExpressionParameters usage in the Inspector. If you use prebuilds, click Update prebuild before re-uploading.

Since v3.1.0, new installations use the regular 可愛いポーズ Prefab. Turn off unneeded Features for a pose-selection-only minimum of 8 bit. Configurations with many poses may require additional pose-selection bits.

Old 8bit Prefabs remain in Editor/Legacy to preserve existing avatar and preset references. There is no need to delete or replace existing Prefabs. The 8bit edition no longer appears in the Unity menu for new installations.

## Where to configure settings

| Tab | Available settings |
| --- | --- |
| Features | In-game menu features, convenience features, breathing settings, icon images and ExpressionParameters usage |
| Poses | Select poses, edit details, search, batch add, reorder, preview and adjust animations |
| Avatar Setup | Avatar-specific correction, knee correction, original/custom motion imports and preset changes |

Open settings expands detailed controls below that item. Configure breathing under Features > Convenience > Animate breathing.

Use original standing, crouching and prone poses automatically imports the avatar's existing poses. To assign your own motions, use the separate Open import settings control and choose a motion for each type, such as standing, Crouching and Prone.

Presets are at the bottom of Avatar Setup. Apply this preset replaces the current pose settings, so save existing adjustments before switching.

### Per-feature parameter usage

- Breathing motion uses 0 bit. Only Menu features > Breathing, used to stop/resume it in-game, costs 1 bit for synchronized ON/OFF.
- Photo Mode uses 0 bit locally. Convenience > Sync Photo Mode uses 16 bit. Keep your head visible in Photo Mode uses 0 bit.
- Foot Height and Floor Height each use 8 bit. Move Floor Height away from the center to move vertically; return near 50% to end correction.
- Roll Over alone uses 10 bit. It shares 1 bit with Reduce pose distortion from head rotation, so enabling both still totals 10 bit.
- Mirror and Disable Gestures each use 1 bit.

The Inspector total covers the posing tools on the avatar. It excludes clothing and other gimmicks. Shared settings are counted once even when multiple posing tools are used.

### Previewing and editing poses

Use Preview on a pose under Poses to display it in the Scene. For finer changes, open Animation adjustment, adjust while previewing and save.

Quick previews do not run MA or NDMF build processing. Check clothing and floor-position correction assembled during the build in the built avatar before uploading as well.

Search pose names with the magnifying-glass tab on the left. Choose a destination under Details > Order or use the up/down buttons to reorder poses. Add multiple animations by dragging them to the add area or using Load selected clips from Project.

Update pose thumbnails generates images after a confirmation dialog. Generate pose icons makes in-game poses easier to recognize but adds image-generation time to builds. Select Reduce icon size to lower storage usage. Pose icons are not generated for Android.

## Basic in-game controls

- Select poses in each category through the Expressions menu. In VR, head height switches standing, crouching, sitting and lying postures.
- While lying, face orientation switches back/front lying. When both poses are selected, jumping in place also switches them. Disable this under Features > Convenience > Switch lying posture by jumping in Unity (enabled by default). Adjust category-switching heights using the thresholds in Settings.
- On desktop, use C and Z to change posture. If Z does not reach a lying pose, raise the lying-height threshold in Settings.
- Disable Gestures uses the hand shapes assigned to the pose instead of controller finger gestures.
- Foot Height adjusts the feet side while preserving head position. Floor Height moves the whole body, including the head, vertically. They appear in that order in Settings.
- Moving forward with Photo Mode > Distance turns the avatar toward you. Use Direction to turn it and enable Lock Feet when ready. Exit Photo Mode restores distance/rotation and releases foot lock.
- Breathing is available when breathing animation is enabled. Set intensity in Unity and switch it ON/OFF in-game.

## Prebuilds and warnings

Update prebuild reuses generated data to speed up avatar builds. Without a prebuild, the necessary data is generated during a normal build.

After settings changes, Check settings at the top of the Inspector and Hierarchy markers notify you that an update is needed. Warning display settings are inside Check settings. Hiding a warning does not fix configuration issues or refresh generated data.

## Usage notes

- Pose locking during full-body tracking is unsupported.
- Body shape, clothing or avatar modifications may require additional adjustments.
- Special Base layers or other pose-changing gimmicks may not integrate as intended. If locks do not work correctly, also check Avatar Setup > Integrate tracking locks with other tools.
- Photo Mode movement/rotation and Floor Height also correct default/custom motions when no tool pose is selected. Check the actual VRChat client for viewpoint behavior and replacement default motions.
- Disable VRChat idle sway targets the default idle animation; it does not stop movement from every other cause.

## Documentation and support

Open the manual, support or changelog through Help / Changelog at the top of the Inspector. For detailed shared-feature explanations, also see Packages > Unisaki Posing System > README in Unity's Project window.

- [Official manual](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Support](https://help.unisakistudio.jp/)

For issue reports, include this product and Unisaki Posing System versions; Unity, VRChat SDK, Modular Avatar and NDMF versions; avatar used; reproduction steps; and Console error details.

## Distributing presets

The following applies to data created with Animation adjustment.

You may freely distribute or sell adjustment animation files created with this feature, and presets created with those files assigned, without obtaining permission from Unisaki Studio. Please share them, for example with your own avatar distributions or as presets for avatars not bundled with the tool.

## Products with included integration settings

Our shop independently creates these integration settings. We consider the corresponding authors' permission unnecessary and have not requested it. Contact the shop by message to request distribution or removal of integration settings. You must purchase/download the integrated product separately. For problems with these settings, contact our shop rather than the other product's author.

可愛い座りツール
https://yunisaki.booth.pm/items/3611536

添い寝ツール
https://yunisaki.booth.pm/items/3670993

少女モーション集vol.1 by ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

VRC想定移動モーション（無料配布） by カトのVRC道具屋
https://booth.pm/ja/items/1285101

ごろ寝システムEX by minminmart
https://minminmart.booth.pm/items/4233545

## Terms of use

This tool may be used only by users who agree to the following terms, created using the VN3 license.

[Terms of use (Japanese)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

The source code and resources in this repository are not open source. A legitimate product purchase and agreement to the terms of use are required.

[Terms of use (English)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
