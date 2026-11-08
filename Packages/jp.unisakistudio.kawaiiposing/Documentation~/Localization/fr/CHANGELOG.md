# Historique des modifications

## [3.2.0] - Non publié

### Ajouts

- Affichage de l’Inspector, des commandes d’édition, des dialogues d’installation, des noms de poses standards et des menus VRChat générés en 30 langues.
- Choix de langue unifié pour l’Inspector et les menus du jeu. La langue de l’ordinateur est utilisée initialement, puis le dernier choix est réutilisé dans les autres projets du même utilisateur du système.
- Ouverture du README, de l’historique et du guide hors ligne dans la langue choisie.
- Noms d’affichage des 128 poses standards et descriptions de toutes les fonctions harmonisés avec la terminologie existante.

### Compatibilité

- Conservation des réglages existants de l’avatar, des noms personnalisés, des références d’assets, des identifiants de paramètres et du stockage de la licence.

## [3.1.2] - 2026-11-09

- Le verrouillage de la tête peut désormais être changé dans « Réglages → Verrouillage automatique de la tête sur le dos » du menu EX, même si « Hauteur pieds » est désactivé. Les avatars dont cette entrée avait disparu dans les versions précédentes la récupèrent après mise à jour et nouveau build.
- Prise en charge de Unisaki Posing System 3.1.2. Correction du visage restant orienté vers le haut après s’être relevé d’une pose sur le ventre avec « Réduire les déformations liées à la rotation de la tête » actif.

Dans ALCOM / VCC, mettez Kawaii Posing à jour vers 3.1.2. Unisaki Posing System 3.1.2 est également nécessaire. Si vous utilisiez le précalcul, cliquez sur « Actualiser le précalcul », enregistrez la scène, puis reconstruisez et renvoyez l’avatar.

## [3.1.1] - 2026-11-08

- « Hauteur sol » et « Se retourner », lorsqu’ils sont activés, apparaissent dans « Réglages » du menu EX de VRChat même si « Miroir » est désactivé.
- Les retournements corrects sont conservés pour « Jambes tendues », « Relax » et « Un genou levé », même après réorganisation, suppression ou renommage dans une ancienne version. Ils sont aussi conservés après un Unpack complet si la pose d’origine reste identifiable. Les poses personnelles, les retournements volontairement désactivés et les mouvements latéraux remplacés sont préservés.
- Correction du bref passage sur le ventre à la sélection d’avatar dans VRChat, et du bref passage sur le dos après un saut lorsque seules des poses sur le ventre sont sélectionnées. Désactivez le changement par saut dans « Fonctions → Fonctions pratiques → Changer de pose allongée en sautant » si nécessaire. Il est activé par défaut.
- Si la référence de l’Animator Controller de poses commun est perdue après une mise à jour et peut être restaurée, un avertissement apparaît et le Controller est reconstruit depuis les réglages. Les références partagées par plusieurs avatars sont conservées.
- Le menu d’ajout place désormais le Prefab officiel même si vous avez enregistré un autre Prefab nommé 「可愛いポーズ」.
- Si l’ajout de 添い寝ツール est demandé sans que le produit nécessaire à l’intégration soit présent, un message indique quoi installer d’abord.

Dans ALCOM / VCC, mettez Kawaii Posing et Unisaki Posing System tous deux à jour vers 3.1.1. Si vous utilisiez le précalcul, cliquez sur « Actualiser le précalcul » dans 「可愛いポーズ」 de la scène et enregistrez celle-ci. Reconstruisez et renvoyez l’avatar pour appliquer ces changements dans VRChat.

## [3.1.0] - 2026-11-07

- Ajustement IK automatique des membres selon la morphologie pour 53 des 85 poses fournies.
- Retournement par inclinaison de la tête pour les poses sur le dos « Jambes tendues », « Relax » et « Un genou levé ».
- Position et orientation de l’avatar réglables en Mode photo, avec choix de synchronisation et de maintien de votre tête visible.
- « Hauteur sol » déplace tout le corps jusqu’à 3m vers le haut ou le bas, indépendamment de « Hauteur pieds ».
- Ajout de la respiration, de la suppression du balancement d’attente standard et de la réduction des déformations liées à l’orientation du cou.
- Affichage des fonctions et de la consommation des paramètres dans l’Inspector ; recherche, ajout groupé, réordonnancement et aperçu simple des poses dans la Scene.
- Accélération des changements debout, accroupi et assis en mode bureau.
- Amélioration des avertissements de précalcul après modification, du défilement de l’Inspector et des longues pauses du nettoyage des données générées.
- Prise en charge de Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Bêta ouverte (2026-11-05)

- Début de la bêta ouverte sur GitHub Releases et VPM. Ajustement IK automatique des membres selon la morphologie pour 53 des 85 poses fournies.
- Compatibilité avec le package commun 3.1.0-beta.2. Amélioration du signalement des modifications après précalcul, du défilement dans l’Inspector et des pauses pendant le nettoyage des données générées.

## [3.1.0-beta.1] - Bêta ouverte (2026-11-04)

- Prise en charge de Unisaki Posing System 3.1.0-beta.1.
- Changement de posture ordinaire en mode bureau traité en une seule évaluation, pour les builds ordinaires et le précalcul. La VR et les situations particulières gardent le traitement précédent.
- Reconnaissance des précalculs alpha.3 et antérieurs comme nécessitant une mise à jour.
- Conservation du point de vue lors des changements de hauteur du sol en Mode photo, puis retour à la dernière hauteur à sa sortie.
- Intégration des améliorations jusqu’à alpha.3 concernant l’importation automatique, les ajustements des mouvements importés et la gestion des Controllers générés.

## [3.1.0-alpha.2] - Test fermé (2026-10-26)

### Corrections et modifications

- Mise à jour du système de poses commun vers 3.1.0-alpha.2 avec les corrections de débogage.
- Extension de la hauteur du sol à 3m vers le haut et le bas. 50% représente la hauteur initiale et d’origine.
- Corrections du Mode photo et de hauteur du sol également appliquées aux poses standards et personnelles sans sélection.
- Correction de problèmes d’ajustements manuels, de poses du même nom, de pose initiale et de réglages de retournement des anciens préréglages.

## [3.1.0-alpha.1] - Avant publication

### Ajouts

- Ajout de l’ajustement automatique des membres (IK) selon la morphologie.
- Ajout de l’activation globale ou par pose de l’IK et de l’intégration aux animations d’ajustement.
- Prise en charge du retournement par inclinaison de la tête pour les poses sur le dos « Jambes tendues », « Relax » et « Un genou levé ».
- Ajout des réglages de retournement par pose et du choix d’animation latérale.
- Ajout du Mode photo avec déplacement vers l’avant et rotation.
- Ajout du choix de synchronisation du Mode photo : 0 bit en local uniquement, 16 bit synchronisés.
- Ajout du maintien de votre tête visible pendant le Mode photo.
- Ajout de « Hauteur sol » pour élever tout le corps, tête comprise.
- Ajout de l’animation de respiration, de son intensité et de son menu d’activation dans le jeu.
- Ajout de la suppression du balancement standard de VRChat.
- Ajout de la réduction des déformations liées à la différence d’orientation du cou.
- Ajout de la prévention de flexion inversée des genoux et de leur flexion minimale.
- Ajout de l’activation par fonction et de la consommation des ExpressionParameters.
- Ajout de l’aperçu simple dans la Scene, de la recherche de poses, de l’ajout groupé et du choix de destination dans la liste.
- Ajout de l’historique dans l’Inspector.

### Modifications

- Organisation de l’Inspector en 3 onglets : « Fonctions », « Poses » et « Configuration de l'avatar ».
- Réorganisation des détails de respiration, de l’importation des mouvements personnels et des préréglages.
- Réduction des doublons d’animations générées pour la hauteur des pieds.
- Ajout d’une confirmation avant de mettre à jour les images des poses et regroupement des avertissements dans « Vérifier les réglages ».
- Suppression du menu d’ajout de la version 8bit au profit des options du Prefab standard. Les références existantes sont préservées.
- Prise en charge de Unisaki Posing System 3.1.0-alpha.1 et version minimale du VRChat Avatars SDK portée à 3.10.4.

### Corrections

- Correction de la saisie des noms transférée vers une autre pose et de la fermeture des détails après réordonnancement.
- Correction du chevauchement des aperçus, des décalages de placement et des erreurs sur certains avatars.
- Correction de l’actualisation des avertissements et de l’état du précalcul après modification, ainsi que de certaines erreurs de build.

## [3.0.13] - 2026-09-22
- Mise à jour vers PosingSystem 3.0.17 pour corriger les décalages horizontaux de pose lors d’un changement uniforme de l’échelle de tout l’avatar.
- Ajout du masquage individuel ou groupé des avertissements de pas automatiques, de précalcul absent et de réglages modifiés.
- Correction de l’importation d’animations simples inadaptées lors de l’importation manuelle de mouvements de déplacement.

## [3.0.12] - 2026-09-15
- Ajout d’un préréglage d’avatar (ルリエ).

## [3.0.11] - 2026-09-09
- Ajout de préréglages d’avatars (メルヴィ, ミダリス).
- Correction des remplacements de mouvements du préréglage うらら.

## [3.0.10] - 2026-08-31
- Mise à jour vers PosingSystem 3.0.11 pour corriger les échecs de précalcul avec la dernière version de NDMF et les exceptions lors de l’affichage d’erreurs.

## [3.0.9] - 2026-08-29
- Mise à jour vers PosingSystem 3.0.10 pour alléger le chargement des préréglages et la détermination des icônes de la Hierarchy.
- Correction des erreurs de précalcul en présence de plusieurs systèmes de poses dans un même avatar.

## [3.0.8] - 2026-08-26
- Mise à jour vers PosingSystem 3.0.9 pour corriger l’Avatar d’aperçu invalidé après NDMF, qui causait l’échec `Avatar is null` en Play.

## [3.0.7] - 2026-08-18
- Mise à jour vers PosingSystem 3.0.8 pour corriger un risque de données de posture invalides lors d’une nouvelle correction de hauteur.

## [3.0.6] - 2026-08-12
- Ajout de préréglages d’avatars (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Ajout de préréglages d’avatars (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Ajout de préréglages d’avatars (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Amélioration de l’installation et de la suppression de licence.

## [3.0.2] - 2026-01-04
- Correction du traitement de licence sur Mac et Linux.

## [3.0.1] - 2025-12-28
- Ajout de préréglages d’avatars (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Ajout du précalcul.
- Ajout de l’ajustement de l’animation.
- Ajout des préréglages.
- Ajout au projet au moyen d’un unitypackage.
- Ajout de préréglages d’avatars (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Résolution de problèmes de compatibilité avec certains systèmes.

## [2.2.4] - 2025-04-04
- Correction des changements de pose impossibles avec certains avatars et certaines versions de ModularAvatar.

## [2.2.3] - 2025-03-13
- Correction des mouvements incorrects sur certains avatars, notamment lors des sauts de 森羅.
- Correction des valeurs initiales parfois incorrectes de Sans gestes.

## [2.2.2] - 2025-03-06
- Correction d’erreurs dans certains environnements.

## [2.2.1] - 2025-02-05
- Correction d’un plantage de Unity.
- Ajout de la version au nom de l’outil affiché dans NDMF Console.

## [2.2.0] - 2025-02-02
- Ajout du réglage Sans gestes pour utiliser les mains des animations.
- Ajout de données de mains pour toutes les poses.

## [2.1.6] - 2025-02-02
- Correction des poses déformées en combinaison avec certains outils.
- Correction d’erreurs dépendant des réglages.

## [2.1.5] - 2024-12-10
- Résolution de conflits avec certains systèmes.
- Ajout d’un bouton de suppression de la version Unitypackage.
- Suppression des Prefabs d’intégration de 三点だいしゅきツール après la publication de sa version VCC.

## [2.1.4] - 2024-12-08
- Correction d’erreurs sur certains avatars.
- Correction du verrouillage des pieds inutilisable en cas de conflit avec des systèmes ou avatars.
- Correction du retour des poses aux postures standards de VRC en mode bureau.

## [2.1.3] - 2024-12-01
- Correction des changements de pose impossibles avec des avatars ou systèmes utilisant VRMode avec un type incorrect.
- Ajout d’un signalement dans NDMF-Console lorsque des systèmes entrent en conflit à cause de types de paramètres différents.

## [2.1.2] - 2024-12-01
- Ajout d’une explication dans NDMF-Console lorsqu’une erreur d’un autre outil entraîne une erreur de Unisaki Posing System pendant le build de l’avatar.
- Correction d’erreurs de build sur certains avatars.
- Amélioration du comportement juste après le chargement de l’avatar.
- Suppression du traitement de déplacement d’origine de l’avatar, qui empêchait le fonctionnement sur certains avatars.

## [2.1.1] - 2024-11-20
- Correction d’un problème empêchant le build.

## [2.1.0] - 2024-11-20
- Résolution de l’enfoncement des pieds et des hanches dans le sol en mode bureau afin de prendre proprement toutes les poses.
- Ajout du changement de pose indépendamment de la hauteur de la tête.
- Ajout d’un mode sans génération d’icônes pour envoyer les avatars Quest.
- Ajout de plusieurs avertissements en cas de problème avec l’avatar.
- Résolution des conflits entre les verrouillages et l’AFK ou les verrouillages de bras d’autres outils.
- Ajout du verrouillage automatique du cou sur le dos.
- Réorganisation d’ExpressionsMenu : sélection des poses dans un dossier séparé, verrouillages au premier niveau.

## [2.0.0] - 2024-11-14
### Corrections
- Conversion en package VPM pour prendre en charge VCC.
- Correction de la version 8bit qui consommait 17bit.

## [1.15.0] - 2024-11-04
### Corrections
- Correction d’erreurs et de dysfonctionnements.

## [1.14.0] - 2024-07-05
### Corrections
- Correction des problèmes avec VRCFury.

## [1.13.0] - 2024-04-11
### Corrections
- Ajout des réglages d’intégration avec ごろ寝システムEX.

## [1.12.0] - 2024-03-31
### Corrections
- Correction de l’outil inutilisable selon l’état d’ExMenu.
- Ajout de la fonction miroir aux réglages.
- Correction de la pose du chat.
- Ajout de ５ poses couchées de profil.

## [1.11.0] - 2024-03-12
### Corrections
- Correction des poses incorrectes lorsque la tête est haute.

## [1.10.0] - 2024-03-10
### Corrections
- Ajout des poses debout avec 15 poses.
- Correction des pieds bougeant involontairement sur certains avatars et environnements.
- Ajout d’une version ExpressionParameters8bit.

## [1.9.0] - 2024-03-05
### Corrections
- Correction des pieds bougeant involontairement sur certains avatars.
- Uniformisation des WriteDefaults.
- Ajout de ７ poses accroupies et de ８ poses assises.

## [1.8.0] - 2024-02-25
### Corrections
- Correction de l’échec d’envoi avec ModularAvatar1.9.0 et versions ultérieures.
- ModualrAvatar1.9.0 ou ultérieur est désormais nécessaire.

## [1.7.0] - 2024-02-23
### Corrections
- Ajout du réglage des seuils de hauteur de tête pour chaque posture.
- Correction des poses ou pieds incorrects sur certains avatars, notamment pendant un saut.
- Consommation des ExpressionParameter réduite de 54 à 16bit.

## [1.6.0] - 2024-02-20
### Corrections
- Correction de l’impossibilité de s’asseoir en mode VR.

## [1.5.0] - 2024-02-18
### Corrections
- En mode bureau, les poses assises peuvent désormais être utilisées même en maintenant C.

## [1.4.0] - 2024-02-17
### Corrections
- Correction de l’intégration 添い寝 inutilisable sans l’intégration 三点だいしゅき.
- Correction des pieds bloqués après un saut.

## [1.3.0] - 2024-02-16
### Corrections
- Correction d’un nombre anormal de VRCContactSender/Receiver configurés.

## [1.2.0] - 2024-02-16
### Corrections
- Correction d’une erreur de build lors de l’envoi.

## [1.1.0] - 2024-02-15
### Corrections
- Correction des valeurs par défaut incorrectes avec plusieurs Prefabs.
- Correction des réglages d’intégration de 可愛い座り.

## [1.0.0] - 2024-02-14
### Publication
