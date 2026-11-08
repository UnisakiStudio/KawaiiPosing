# Kawaii Posing — Guide d’utilisation en français

Kawaii Posing propose 85 poses pour le mode bureau et la VR à trois points : 15 debout, 20 accroupies ou sur chaise, 17 assises au sol, 17 couchées sur le dos et 16 sur le ventre.

Ce guide décrit l’installation, la configuration de l’avatar, les commandes VRChat, l’édition des poses, les mises à jour et le dépannage. Le ZIP acheté contient `START_HERE.html`, le chemin le plus rapide vers l’installation.

## Avant de commencer

- Utilisez un projet d’**avatar** VRChat sous Unity 2022.3, créé ou géré avec VRChat Creator Companion (VCC) ou ALCOM.
- Packages nécessaires : VRChat Avatars SDK 3.10.4 ou ultérieur ; Modular Avatar 1.x à partir de 1.15.1 ; NDMF 1.x à partir de 1.14.0.
- L’outil est prévu pour les avatars Humanoid en mode bureau et en VR à trois points (casque et deux contrôleurs). Le verrouillage de pose avec suivi du corps entier actif n’est pas pris en charge.
- Sauvegardez un projet existant avant installation ou mise à jour. Résolvez d’abord les erreurs de compilation Unity en cours.
- L’installateur télécharge le produit et ses dépendances depuis leurs dépôts. Une connexion Internet est nécessaire. Les modèles d’avatars, VRChat SDK, Modular Avatar et NDMF ne sont pas inclus dans ce ZIP.

## 1. Installer la licence et le produit

1. Extrayez tout le ZIP dans un dossier ordinaire en dehors de votre projet Unity.
2. Ouvrez le projet d’avatar voulu dans Unity. Importez `Installer/KawaiiPosing_Installer.unitypackage` avec **Assets > Import Package > Custom Package**, ou ouvrez le fichier avec Unity.
3. Lisez les demandes de confirmation d’importation et d’installation. La confirmation de licence précise quelles licences seront installées. Utilisez **Langue…** (ou **言語...**) dans une confirmation pour modifier la langue de l’installateur.
4. Confirmez l’installation de la licence. Elle couvre aussi Unisaki Posing System utilisé par ce produit. L’installateur peut ensuite proposer de retirer ses propres fichiers de configuration ; ce nettoyage ne supprime pas la licence installée.
5. Vérifiez la confirmation de l’installateur automatique de packages. Elle liste les packages et dépôts à ajouter ainsi que les anciens fichiers ou dossiers à supprimer. Continuez si ces éléments correspondent à votre intention.
6. Attendez la fin de l’importation et de la compilation Unity. Si l’installation des packages ne se termine pas automatiquement, ouvrez le projet dans VCC ou ALCOM et ajoutez **Kawaii Posing** et **Modular Avatar**. **Unisaki Posing System** et **NDMF** sont des dépendances. `Optional-VCC-Links` contient les raccourcis de dépôts d’origine pour les utilisateurs de VCC sous Windows.
7. Si vous avez annulé une confirmation, réimportez l’installateur lorsque vous êtes prêt. Tant que l’activateur est présent, sa commande d’installation de licence est aussi accessible dans **Tools > Unisaki Studio**. Dans les anciennes versions, ce sous-menu porte le nom **ゆにさきスタジオ**.

### Contenu installé par ce téléchargement

**Kawaii Posing 3.2.0 avec Unisaki Posing System 3.2.0.** Cette version est en développement et n’a pas été publiée. Elle ajoute les dialogues d’installation, l’Inspector et les menus Unity, les noms de poses standards, les menus du jeu et la documentation hors ligne en trente langues. La date de sortie n’est pas encore fixée. Changez la langue avec le sélecteur en haut de l’Inspector. Après publication, l’installateur téléchargera ces versions et leurs dépendances compatibles depuis les dépôts VPM. Préparer une version localement ne publie pas ces packages.

Kawaii Posing comprend la bibliothèque de poses, les outils de configuration et les préréglages d’ajustement d’avatar. L’installateur active la licence locale existante du produit, sans nouveau champ de clé de licence Gumroad. Ne publiez jamais les fichiers de l’installateur ou les données de licence dans une demande d’assistance publique.

Les préférences de langue sont enregistrées dans Unity EditorPrefs pour l’utilisateur courant du système et partagées entre ses projets Unity sur cet ordinateur. Sans préférence enregistrée, l’installateur suit la langue du système ; l’anglais est utilisé pour les langues non prises en charge. Les licences conservent leur stockage existant : clé de registre `Software/UnisakiStudio` de l’utilisateur sous Windows, fichiers de licence par utilisateur sur macOS/Linux. Changer de langue ne supprime pas de licence.

## 2. Ajouter l’outil à un avatar

1. Dans la **Hierarchy**, sélectionnez l’avatar avec un **VRC Avatar Descriptor**, ou l’un de ses enfants. Utilisez un avatar placé dans une scène, plutôt qu’un asset Prefab dans Project ou le mode Prefab.
2. Faites un clic droit sur l’avatar et choisissez **Unisaki Studio > Ajouter Kawaii Posing**. Si la version installée utilise des menus japonais, choisissez **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. L’outil est ajouté dans l’avatar. Son nom d’objet enregistré peut rester **可愛いポーズ** même si les libellés sont traduits.
4. Si un préréglage compatible est proposé, appliquez-le comme point de départ. Sinon, ouvrez **Configuration de l'avatar** et choisissez un préréglage ou ajustez vous-même les poses.
5. L’installateur peut proposer un précalcul. Celui-ci est facultatif : un build normal génère aussi les données nécessaires. Réutilisez les précalculs pour réduire les temps de build ultérieurs.
6. Sélectionnez l’objet de l’outil, choisissez vos poses et fonctions, puis envoyez l’avatar normalement avec VRChat SDK.

### Choix de langue et correspondance des libellés

Cette version propose **Language / 言語** en haut de l’Inspector de l’outil. Ce choix unique contrôle l’Inspector et le menu généré dans le jeu. La langue est enregistrée dans l’avatar, et le dernier choix est mémorisé pour les autres outils et projets sur cet ordinateur. Renvoyez l’avatar pour modifier la langue visible dans VRChat.

Utilisez le tableau ci-dessous pour suivre les anciens tutoriels japonais. Cette version comprend le sélecteur de langue, l’Inspector localisé, les noms de poses standards traduits et les menus du jeu dans les 30 langues.

| Français | Libellé japonais des anciennes versions |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Fonctions | 機能 |
| Poses | ポーズ一覧 |
| Configuration de l'avatar | アバター調整 |
| Ouvrir les réglages | 設定を開く |
| Actualiser le précalcul | プレビルドを更新 |
| Vérifier les réglages | 設定の確認 |
| Aperçu | プレビュー |
| Ajustement de l'animation | アニメーション調整 |
| Recharger | 再読込 |

L’Inspector fourni, les dialogues d’édition et d’installation, les noms de poses standards et les menus générés sont traduits dans les 30 langues sélectionnables. Le README, l’historique et le guide hors ligne sont fournis dans chaque langue. Les noms d’avatars, d’objets enregistrés, de poses personnalisées, de fichiers d’assets et les identifiants internes des paramètres peuvent conserver leur orthographe d’origine.

Les [références rapides en 30 langues](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) présentent les descriptions des fonctions et les tableaux de noms des poses standards. Ce sont des références concises ; utilisez la liste des langues pour accéder à la documentation complète.

## 3. Choisir les poses et les fonctions

L’Inspector comporte trois onglets principaux :

| Onglet | Utilisation |
| --- | --- |
| **Fonctions** | Commandes du menu du jeu, comportements facultatifs, respiration, options d’icônes et consommation des paramètres d’expression. |
| **Poses** | Poses actives, catégories et recherche, ordre, ajout d’animations, aperçu, détails et ajustement de l’animation. |
| **Configuration de l'avatar** | Corrections propres à l’avatar et aux genoux, importation des mouvements d’origine ou personnels et préréglages. |

Activez uniquement les commandes de menu que vous comptez utiliser. Par exemple, ajouter **Miroir** permet d’activer ou désactiver le miroir dans VRChat ; toutes les poses ne sont pas forcées en miroir.

Kawaii Posing comprend des préréglages d’avatars et l’IK pour les poses compatibles. Trois poses standards sur le dos ont déjà des mouvements latéraux affectés : **Jambes tendues (足伸ばし)**, **Relax (リラックス)** et **Un genou levé (膝立て)**. Utilisez le préréglage correspondant et vérifiez les réglages de retournement de chaque pose si vous avez modifié ou remplacé ces entrées.

### Préréglages et adaptation

Les préréglages se trouvent près du bas de **Configuration de l'avatar**. Recherchez le nom de l’avatar, puis appliquez un préréglage pour remplacer les réglages de poses actuels. Enregistrez ou sauvegardez vos ajustements avant de changer de préréglage. Celui-ci est un point de départ : les proportions, tenues et modifications de l’avatar peuvent encore nécessiter des corrections manuelles.

Utilisez **Ajustement de l'animation** sur une pose pour prévisualiser et modifier la position du corps et des membres. Enregistrez l’animation d’ajustement depuis cette fenêtre lorsque vous avez terminé. Pour les poses compatibles, l’ajustement automatique des mains et pieds (IK) peut être activé globalement et individuellement. Intégrer le résultat IK actuel crée une animation d’ajustement et désactive l’IK de la pose pour permettre les retouches manuelles ; le clip source est conservé.

**Empêcher les genoux de se plier à l'envers** propose des réglages supplémentaires, dont la flexion minimale. Les corrections propres à l’avatar nécessitent les données correspondantes, et certaines corrections ne peuvent pas se cumuler avec l’IK des poses.

### Mouvements d’origine et personnels

**Utiliser les poses debout, accroupies et sur le ventre d'origine** détecte les mouvements dans la couche Base de l’avatar pendant la génération. **Utiliser vos propres mouvements** ouvre des réglages d’importation séparés pour chaque type. Choisissez un mouvement par type. Une affectation manuelle est prioritaire sur l’importation automatique du type concerné.

L’importation automatique s’applique à la copie du build. Elle ne recopie pas les animations détectées dans la liste d’affectations manuelles de la scène et ne modifie pas les Controllers d’origine. Effacez le remplacement manuel d’un type pour rétablir sa détection automatique. Les couches Base personnalisées et autres systèmes de locomotion peuvent nécessiter des ajustements particuliers.

## 4. Utiliser l’outil dans VRChat

Ouvrez le menu **Expressions** de votre avatar, puis **Kawaii Posing**. Choisissez une pose dans chaque catégorie que vous souhaitez utiliser. La sélection d’une pose et celle d’une fonction sont deux actions distinctes.

- **VR à trois points :** baissez ou relevez la tête pour passer entre debout, accroupi ou sur chaise, assis au sol et allongé. Réglez les seuils de hauteur dans le menu de l’outil si les changements arrivent trop tôt ou trop tard.
- **Mode bureau :** utilisez **C** pour vous accroupir et **Z** pour vous allonger. Si Z vous laisse assis, augmentez le seuil de hauteur allongée dans les réglages.
- **Sur le ventre ou le dos :** l’outil utilise l’orientation du visage pour choisir le côté. Si les deux sont sélectionnés, sauter sur place peut les permuter. Vous pouvez désactiver ce changement dans **Fonctions > Fonctions pratiques** de Unity ; il ne consomme aucun paramètre synchronisé supplémentaire.
- **Verrouillages :** utilisez les verrouillages de tête, de bras et de pieds selon vos besoins. Désactivez les gestes pour utiliser les mains de la pose à la place des gestes des contrôleurs.
- **Miroir :** inversez une pose pour faire face à un ami ou adapter une composition.

### Hauteur pieds et Hauteur sol

**Hauteur pieds** ajuste les pieds en conservant la position de la tête. Utilisez ce réglage lorsque les pieds flottent ou s’enfoncent alors que la tête est déjà à la bonne hauteur.

**Hauteur sol** déplace le corps entier, tête comprise. Utilisez-le pour un canapé, un lit ou une surface surélevée, même sans collider. Sur la commande centrée du système commun actuel, **50% correspond à la hauteur d’origine**, 0% à 3 m plus bas et 100% à 3 m plus haut. Revenez près de 50% pour terminer le décalage. Le fonctionnement peut différer dans les anciennes versions ; vérifiez la version installée et mettez à jour le système commun avec le produit.

### Mode photo

Activez l’entrée **Mode photo** dans Unity avant d’envoyer l’avatar. Dans VRChat, choisissez une pose, avancez jusqu’à 3 m avec **Distance**, puis faites pivoter l’avatar avec **Direction**. Le verrouillage des pieds est facultatif pendant la composition. **Quitter photo** réinitialise distance et rotation et déverrouille les pieds.

Le Mode photo est local par défaut. Pour montrer la position et la rotation aux autres, activez **Synchroniser le Mode photo** dans Unity avant l’envoi ; cela utilise 16 bits synchronisés. **Garder la tête visible en Mode photo** agit sur votre propre vue et ne consomme aucun bit synchronisé.

### Respiration et retournement

La respiration se règle par catégorie dans **Fonctions > Fonctions pratiques > Animer la respiration**. Choisissez Aucun, Faible, Moyenne, Forte, Rapide ou une animation personnalisée. Le mouvement seul ne consomme aucun bit synchronisé. Le menu d’activation de la respiration utilise 1 bit.

Le retournement nécessite une pose allongée compatible et l’entrée de menu **Se retourner**. Activez-le pour la pose et définissez son animation latérale si nécessaire. Dans VRChat, choisissez cette pose, activez le retournement et libérez la tête ou le cou. L’inclinaison latérale de la tête contrôle alors le retournement. Le réglage MotionTime ordinaire n’est plus disponible pour cette pose pendant son utilisation.

Les trois poses standards sur le dos indiquées plus haut comprennent leurs mouvements latéraux. Les autres poses nécessitent un mouvement et des réglages adaptés. Les préréglages importés ou personnels peuvent avoir des affectations différentes.

## 5. Modifier, ajouter et prévisualiser les poses

Dans **Poses**, choisissez une catégorie ou l’onglet de recherche. La recherche accepte les noms japonais d’origine et les traductions disponibles. Ouvrez les **Détails** d’une pose pour modifier son animation, son icône, son ordre et ses options de lecture.

Pour ajouter plusieurs animations, glissez les clips dans la zone d’ajout ou sélectionnez-les dans Project et utilisez la commande d’importation des clips sélectionnés. Les références en double au même clip sont retirées. Changez la destination dans les Détails ou utilisez les boutons haut et bas.

**Aperçu** affiche une pose dans la Scene sans ouvrir toute la fenêtre d’ajustement. Cet aperçu léger n’exécute pas Modular Avatar ou NDMF : vérifiez le build final pour les vêtements, les corrections de sol et les autres fonctions ajoutées au build.

Les icônes générées depuis votre avatar aident à identifier les poses, mais leur génération prend du temps et peut augmenter la taille des données. Réduisez leur résolution pour économiser de la place. Les builds Android ne génèrent pas d’icônes de poses. Régénérez-les après modification de l’avatar ou de sa tenue si nécessaire.

## 6. Mémoire des paramètres

L’Inspector montre la contribution des outils de poses, pas le total de l’avatar entier. Les vêtements et autres systèmes peuvent consommer davantage de mémoire. Les réglages communs à plusieurs outils ne sont pas comptés deux fois. Les configurations personnelles avec de nombreuses poses supplémentaires peuvent nécessiter davantage de bits de sélection.

| Fonction | Bits synchronisés supplémentaires |
| --- | ---: |
| Sélection des poses, configuration standard minimale | 8 |
| Miroir | 1 |
| Sans gestes | 1 |
| Animation de respiration | 0 |
| Activation de la respiration dans le menu | 1 |
| Hauteur pieds | 8 |
| Hauteur sol | 8 |
| Mode photo local uniquement | 0 |
| Synchroniser le Mode photo | 16 |
| Garder la tête visible en Mode photo | 0 |
| Désactiver le balancement au repos de VRChat | 0 |
| Se retourner | 10 |

Se retourner partage 1 bit avec la correction de posture liée à l’orientation du cou : activer les deux utilise toujours 10 bits au total. La consommation affichée dans votre version installée est la référence pratique pour votre configuration.

## 7. Mise à jour et précalcul

1. Sauvegardez le projet et enregistrez la scène de travail.
2. Dans VCC ou ALCOM, mettez à jour ensemble **Kawaii Posing** et **Unisaki Posing System**. Gardez aussi des versions compatibles du SDK, de Modular Avatar et de NDMF.
3. Attendez la fin de la compilation. Sélectionnez l’outil déjà installé et vérifiez ses poses, ses réglages et la consommation des paramètres.
4. Si vous utilisez le précalcul, choisissez **Actualiser le précalcul**, puis renvoyez l’avatar.

Les réglages existants de l’outil sont conservés. Les anciens Prefabs 8-bit restent présents pour la compatibilité ; les références existantes ne nécessitent ni suppression ni remplacement de l’outil. Les nouvelles installations utilisent le Prefab normal ; désactivez les fonctions inutilisées pour limiter la consommation des paramètres.

Un avertissement de précalcul périmé signifie que les réglages ont changé depuis la génération des données en cache. Actualiser le précalcul régénère ces données. Masquer l’avertissement ne met pas le précalcul à jour et ne résout pas sa cause. Un build normal peut générer les données nécessaires sans précalcul manuel systématique.

## 8. Dépannage

| Symptôme | Vérifications |
| --- | --- |
| Menu d’ajout absent | Vérifiez que le produit **et** Unisaki Posing System sont installés et résolvez les erreurs de compilation dans la Console Unity. L’installateur de licence seul ne constitue pas la bibliothèque de poses. |
| Installateur annulé ou fichiers retirés | Réimportez l’installateur acheté lorsque vous êtes prêt et relisez les confirmations. |
| Licence apparemment absente dans un autre projet | Importez l’installateur acheté avec le même compte du système. Après un changement d’ordinateur ou de compte, installez-y aussi la licence. Les préférences de langue ne se transfèrent pas automatiquement entre ordinateurs. |
| Aucune pose dans VRChat | Ajoutez l’outil sous le bon avatar de la scène, activez les poses voulues, consultez les avertissements et envoyez cet avatar. Vérifiez le SDK et les autres outils de locomotion. |
| Z n’atteint pas la position allongée | Augmentez le seuil de hauteur allongée dans les réglages de l’outil dans le jeu. |
| Mains ou genoux mal alignés | Essayez le préréglage d’avatar adapté, puis l’IK compatible et/ou l’ajustement de l’animation. Vérifiez la déformation de la tenue dans le build final. |
| Retournement inactif | Utilisez une pose allongée compatible, activez le retournement dans ses réglages et dans le menu, puis libérez la tête ou le cou. Essayez d’abord l’une des trois poses standards compatibles. |
| Déplacement photo invisible pour vos amis | Activez **Synchroniser le Mode photo** dans Unity, vérifiez les paramètres et renvoyez l’avatar. |
| Langue modifiée dans Unity mais pas dans VRChat | Renvoyez l’avatar. Vérifiez le sélecteur unique en haut de l’Inspector dans les versions multilingues. |
| Erreurs de build ou précalcul | Lisez la **première** erreur pertinente de la Console. Sauvegardez la scène, mettez à jour ou réinstallez le produit et le système commun avec VCC/ALCOM, puis contactez l’assistance si le problème persiste. Conservez les objets ajustés et GeneratedResources sauf consigne précise de récupération donnée par l’assistance. |

Pour l’assistance, indiquez les versions du produit et du système commun, de Unity/SDK/Modular Avatar/NDMF, le nom d’avatar, les étapes exactes de reproduction et l’erreur pertinente de la Console. Retirez des publications publiques les fichiers privés, le contenu de l’installateur, les valeurs de licence et les détails de compte.

- [Assistance](https://help.unisakistudio.jp/)
- [Manuel illustré en ligne (japonais)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Page du produit sur Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licences et crédits

Une [traduction anglaise de référence des conditions du produit](../../Terms.en.html) est fournie avec l’original japonais.

Lisez les conditions originales du produit et celles du système commun à côté du README du package, ou dans le dossier `Licenses` du ZIP acheté. L’accord anglais de Unisaki Posing System fourni est une traduction de référence existante pour ce système ; les conditions japonaises du produit restent fournies séparément. Ce guide ne modifie pas les accords et n’accorde pas de droits supplémentaires. Contactez l’assistance pour toute question sur l’utilisation ou la redistribution des données du produit.

L’installateur inclut une version modifiée de **VPMPackageAutoInstaller**, par **anatawa12**, avec **SimpleJson** et **semver.net**. Leurs avis de droit d’auteur et textes de licence MIT se trouvent dans `ThirdPartyNotices.txt` du ZIP acheté. La bibliothèque de poses et les autres ressources sont soumises à leurs propres licences produit.
