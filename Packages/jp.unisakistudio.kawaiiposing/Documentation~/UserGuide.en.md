# Kawaii Posing Tool — English User Guide

Kawaii Posing provides 85 poses for desktop and three-point VR: 15 standing, 20 crouching/chair, 17 floor-sitting, 17 back-lying, and 16 front-lying poses.

This guide covers installation, avatar setup, VRChat controls, pose editing, updates, and troubleshooting. The purchased ZIP includes `START_HERE.html` for the quickest route to installation.

## Before you start

- Use a Unity 2022.3 VRChat **avatar** project created or managed with VRChat Creator Companion (VCC) or ALCOM.
- Required packages: VRChat Avatars SDK 3.10.4 or later; Modular Avatar 1.x, version 1.15.1 or later; and NDMF 1.x, version 1.14.0 or later.
- The tool is for Humanoid avatars in desktop mode and three-point VR (headset and two controllers). Pose locking while full-body tracking is active is unsupported.
- Back up an existing project before installing or updating. Finish any outstanding Unity compile errors first.
- The installer downloads the product and dependencies from their package repositories. An internet connection is required. Avatar models, VRChat SDK, Modular Avatar, and NDMF are not included in this ZIP.

## 1. Install the license and product

1. Extract the entire ZIP into a normal folder outside your Unity project.
2. Open the intended avatar project in Unity. Import `Installer/KawaiiPosing_Installer.unitypackage` using **Assets > Import Package > Custom Package**, or open the file with Unity.
3. Read the import and installation prompts. The license confirmation explains which product licenses will be installed. Use **Language...** (or **言語...**) in a confirmation dialog to change the installer language.
4. Confirm license installation. The license also covers the shared Unisaki Posing System used by this product. The installer can offer to remove its own setup files afterward; this cleanup does not remove the installed product license.
5. Review the automatic package-installer confirmation. It lists the packages and repositories to add and any legacy files or folders it proposes to remove. Continue when these are the intended items.
6. Allow Unity to finish importing and compiling. If package installation does not finish automatically, open this project in VCC or ALCOM and add **Kawaii Posing Tool** and **Modular Avatar**. The shared **Unisaki Posing System** and **NDMF** are dependencies. `Optional-VCC-Links` contains the original repository shortcuts supplied with the product for Windows VCC users.
7. If a confirmation was cancelled, import the installer again when ready. You can also use its license-install command in **Tools > Unisaki Studio** while the activator is still present. In older builds this submenu is named **ゆにさきスタジオ**.

### What this download installs

**Kawaii Posing Tool 3.2.0 with Unisaki Posing System 3.2.0.** This version is in development and has not been released. It adds thirty-language setup dialogs, Unity Inspector and menus, standard pose names, in-game menus, and offline documentation. The release date has not been set. Use the top-of-Inspector language selector to change the tool language. After publication, the installer will download these versions and their compatible dependencies from VPM repositories. Local release preparation does not publish those packages.

Kawaii Posing Tool includes the pose library, configuration tools, and avatar adjustment presets. The installer activates the product's existing local license; it does not require a new Gumroad license key field. Never post the installer files or license data in a public support request.

Language preferences are stored through Unity EditorPrefs for the current OS user and are shared across Unity projects on this computer. Without a saved preference, the installer follows the OS language; unsupported languages use English. Product licenses retain their existing storage: the current user's `Software/UnisakiStudio` registry key on Windows, and per-user license files on macOS/Linux. Changing a language does not remove a license.

## 2. Add the tool to an avatar

1. In the **Hierarchy**, select the avatar with a **VRC Avatar Descriptor**, or one of its children. Use an avatar placed in a scene, rather than the Project window's prefab asset or Prefab Mode.
2. Right-click the avatar and choose **Unisaki Studio > Add Kawaii Posing**. If the installed build uses Japanese menus, choose **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. The tool is added inside the avatar. Its saved object name may remain **可愛いポーズ** even when display labels are translated.
4. If a matching avatar preset is offered, apply it for a starting fit. Otherwise open **Avatar Setup** and choose a preset or adjust the poses yourself.
5. The installer may offer to prebuild. Prebuilding is optional; a normal avatar build also generates the required data. Reuse prebuilds to reduce later build times.
6. Select the tool object, choose the poses and features you want, then upload the avatar normally through the VRChat SDK.

### Language selection and familiar labels

This version offers **Language / 言語** at the top of the tool Inspector. That single selection controls the Inspector and generated in-game menu. The avatar stores its selected language, and the last choice is remembered for other tools/projects on this computer. Re-upload the avatar to change the language seen in VRChat.

Use the label table below when following older Japanese tutorials. This version includes the language selector, localized Inspector, translated standard pose names, and in-game menus for all 30 languages.

| English | Japanese label in older builds |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Features | 機能 |
| Poses | ポーズ一覧 |
| Avatar Setup | アバター調整 |
| Open settings | 設定を開く |
| Update prebuild | プレビルドを更新 |
| Check settings | 設定の確認 |
| Preview | プレビュー |
| Animation Adjustment | アニメーション調整 |
| Reload | 再読込 |

The bundled Inspector, editor/setup dialogs, standard pose names and generated menus have translations for all 30 selectable languages. The README, changelog and offline manual are provided in each selectable language. Avatar names, saved object names, custom pose names, asset filenames, and internal parameter identifiers may keep their original spelling.

[30-language quick references](../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) cover the feature explanations and standard pose-name tables. These are concise references; use the language index for the full documentation.

## 3. Choose your poses and features

The Inspector has three main tabs:

| Tab | Use it for |
| --- | --- |
| **Features** | In-game menu controls, optional behavior, breathing, icon options, and expression-parameter usage. |
| **Poses** | Enabled poses, category/search, ordering, adding animations, preview, details, and animation adjustment. |
| **Avatar Setup** | Avatar-specific and knee corrections, original/custom motion import, and presets. |

Enable only the menu controls you plan to use. For example, adding **Mirror** to the menu lets you switch mirroring in VRChat; it does not force every pose to stay mirrored.

Kawaii Posing includes avatar presets and supported-pose IK. Three standard back-lying poses have side-lying motions already assigned: **Legs Out (足伸ばし)**, **Relaxed (リラックス)**, and **One Knee Up (膝立て)**. Use the matching preset and inspect each pose’s roll-over setting if you have edited or replaced these entries.

### Presets and fitting

Presets are near the bottom of **Avatar Setup**. Search by avatar name, then apply a preset to replace the current pose settings. Save or back up adjustments before changing presets. A preset is a starting point: body proportions, outfits, and avatar modifications can still require manual corrections.

Use **Animation Adjustment** on a pose to preview and edit body/limb placement. Save the adjustment animation from that window when finished. Where supported, automatic hand and foot adjustment (IK) can be enabled globally and per pose. Baking the current IK result into an adjustment creates an adjustment animation and disables IK for that pose so you can refine it manually; the original source clip is kept.

**Prevent knees bending backward** has additional settings such as the minimum knee bend angle. Avatar-specific corrections are available only when corresponding correction data exists, and some corrections cannot be combined with pose IK.

### Original and custom motions

**Use the avatar's original standing/crouching/prone motions** detects motions from the avatar's Base layer during generation. **Use your own motions** opens separate import settings for each motion type. Choose one motion per type. Manual assignments take priority over automatic import for that type.

Automatic import applies to the build copy. It does not write detected animations back into the scene's manual-assignment list or modify the original controllers. Clear a manual override for a type if you want automatic detection to handle it again. Custom Base layers and other locomotion systems may require individual adjustments.

## 4. Use the tool in VRChat

Open your avatar's **Expressions** menu and enter **Kawaii Posing**. Choose a pose for each posture category you want to use. Selecting a pose and selecting a feature are separate actions.

- **Three-point VR:** lower or raise your head to change between standing, crouching/chair, floor-sitting, and lying postures. Adjust the height thresholds in the tool's settings menu if posture changes happen too early or too late.
- **Desktop:** use **C** to crouch and **Z** to lie down. If Z leaves you sitting, increase the lying-height threshold in the settings menu.
- **Lying front/back:** the tool uses face direction to select front- or back-lying. When both are selected, jumping in place can switch between them. Disable jump switching in Unity's **Features > Convenience features** if you prefer; it adds no synced parameter cost.
- **Locks:** use head, arm, and foot locks as needed. Disable gestures if you want the posed hand shape instead of controller gesture input.
- **Mirror:** flip a selected pose to face a friend or match a composition.

### Foot height and floor height

**Foot height** adjusts the feet while keeping the head in place. Use it when your feet float or sink while the head is already at the right height.

**Floor height** moves the whole body, including the head. Use it for a sofa, bed, or raised surface, including furniture without a collider. On the shared system's current centered control, **50% is the original height**, 0% is 3 m below, and 100% is 3 m above. Return near 50% to end the offset. Older releases may have different control behavior; check the installed version and update the shared system together with the product.

### Photo mode

Enable the **Photo mode** menu entry in Unity before uploading. In VRChat, choose a pose, use **Distance** to move up to 3 m forward, and use **Rotation** to turn the avatar. Foot lock is optional while you arrange the shot. **Exit photo mode** resets distance/rotation and releases the foot lock.

Photo mode is local by default. To show the position and rotation to other people, enable **Sync photo mode** in Unity before uploading; this costs 16 synced bits. **Keep head visible in photo mode** affects your own view and costs no synced bits.

### Breathing and roll over

Breathing can be set per posture category in **Features > Convenience features > Add breathing motion**. Choose none, weak, medium, strong, fast, or a custom breathing animation. The movement itself costs no synced bits. A menu toggle for breathing uses 1 bit.

Roll over requires a supported lying pose and the **Roll Over** menu entry. Enable roll over for the pose and provide its side-lying animation when needed. In VRChat, choose that pose, enable roll over, and release head/neck lock. The head's sideways tilt then controls the roll. Normal MotionTime control is unavailable for that pose while roll over is used.

The three standard back-lying poses listed above include side-lying motions. Other poses require an appropriate motion and pose setting. Imported/custom presets can have different assignments.

## 5. Edit, add, and preview poses

In **Poses**, select a category or use the search tab. Search accepts original Japanese names and available translations. Open a pose's **Details** to edit its animation, icon, ordering, and timing options.

To add several animations, drag clips to the add area or select clips in the Project window and use the selected-clips import command. Duplicate references to the same clip are removed. Change the destination order in Details, or use the up/down controls.

**Preview** shows a pose in the Scene view without opening the full adjustment window. This lightweight preview does not run Modular Avatar or NDMF, so check the final avatar build for clothing, floor correction, and other build-time features.

Pose icons generated from your avatar help identify poses, but generation takes time and can increase avatar data size. Reduce icon resolution to save space. Android builds do not generate pose icons. Regenerate icons after changing the avatar or outfit when required.

## 6. Parameter memory

The Inspector shows the pose tools' contribution, not the entire avatar's total. Clothing and other systems can use additional parameter memory. Common settings shared by multiple pose tools are not counted twice. Custom configurations with many extra poses can need more pose-selection bits.

| Feature | Additional synced bits |
| --- | ---: |
| Pose selection, minimum standard configuration | 8 |
| Mirror | 1 |
| Disable gestures | 1 |
| Breathing movement | 0 |
| Breathing menu toggle | 1 |
| Foot height | 8 |
| Floor height | 8 |
| Photo mode, local only | 0 |
| Sync photo mode | 16 |
| Keep head visible during photo mode | 0 |
| Disable VRChat's default idle sway | 0 |
| Roll over | 10 |

Roll over shares 1 bit with the neck-direction posture correction: enabling both still uses 10 bits in total for those two features. The displayed usage in your installed version is the practical reference for your selected configuration.

## 7. Update and prebuild

1. Back up the project and save your working scene.
2. In VCC or ALCOM, update **Kawaii Posing Tool** and the shared **Unisaki Posing System** together. Also keep required SDK, Modular Avatar, and NDMF versions compatible.
3. Allow compilation to finish. Select the already-installed tool and review its poses, settings, and parameter usage.
4. If you use prebuilds, choose **Update prebuild**, then upload the avatar again.

Existing tool settings are retained. Legacy 8-bit prefabs are kept for compatibility; existing references do not require deleting/replacing the tool. New installations use the normal prefab, and unused features can be disabled to reduce parameter usage.

A stale-prebuild warning means settings have changed since the cached build data was generated. Updating the prebuild regenerates that data. Hiding a warning does not update the prebuild or solve its underlying issue. Normal avatar builds can generate the required data even when you do not manually prebuild each time.

## 8. Troubleshooting

| Symptom | What to check |
| --- | --- |
| No add-tool menu | Check that the product **and** Unisaki Posing System are installed, and resolve Unity Console compile errors. The license installer alone is not the pose library. |
| Installer cancelled or files removed | Reimport the purchased installer when ready. Read its confirmations again. |
| License appears missing in another project | Import the purchased installer under the same OS account. If you changed computer/account, install the license there too. Language preferences do not transfer between computers automatically. |
| No poses in VRChat | Add the tool under the correct scene avatar, enable desired poses, review Inspector warnings, and upload that avatar. Check SDK and other locomotion tools. |
| Z does not reach lying posture | Increase the lying-height threshold in the tool's in-game settings. |
| Hands or knees do not line up | Try the matching avatar preset, then use supported IK and/or Animation Adjustment. Check outfit deformation in the final build. |
| Roll over does not work | Use a supported lying pose, enable both the pose's roll-over setting and menu entry, and release head/neck lock. Check one of the three supported standard poses first. |
| Friends cannot see photo movement | Enable **Sync photo mode** in Unity, check parameter usage, and upload again. |
| Language changes in Unity but not VRChat | Re-upload the avatar. Check the single top-of-Inspector language selector in localization-enabled builds. |
| Build/prebuild errors | Read the **first** relevant Console error. Back up the scene, update/reacquire the product and shared system through VCC/ALCOM, and contact support if the issue continues. Keep adjusted objects and GeneratedResources unless support gives a specific recovery step. |

For support, include the product/shared-system versions, Unity/SDK/Modular Avatar/NDMF versions, avatar name, exact steps to reproduce, and the relevant Console error. Remove private files, installer contents, license values, and account details from public posts.

- [Support](https://help.unisakistudio.jp/)
- [Illustrated online manual (Japanese)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Gumroad product page](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licenses and credits

An [English reference translation of the product agreement](Terms.en.html) is supplied alongside the original Japanese agreement.

Read the original product agreement and the shared-system agreement beside the package README, or in the `Licenses` folder of the purchased ZIP. The supplied English Unisaki Posing System agreement is an existing reference translation for that system; the product's Japanese agreement remains separately included. The guide does not change the agreements or grant additional rights. Contact support for questions about using or redistributing product data.

The installer includes a modified **VPMPackageAutoInstaller** by **anatawa12**, with **SimpleJson** and **semver.net**. Their copyright notices and MIT license texts are in `ThirdPartyNotices.txt` in the purchased ZIP. The pose library and other product resources have their own product licenses.
