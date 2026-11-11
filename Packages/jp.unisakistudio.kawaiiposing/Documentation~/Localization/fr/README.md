# Kawaii Posing

Outil de poses pour VRChat permettant d’utiliser de jolies poses assises ou allongées avec le suivi à 3 points ou en mode bureau. Il comprend 85 poses : 15 debout, 20 accroupies, 17 assises, 16 couchées sur le ventre et 17 sur le dos.

Ce README concerne la version v3.2.0 en développement. La date de sortie officielle n’est pas encore fixée. La version installée apparaît en haut de l’Inspector.

- [Page du produit sur BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Historique des modifications](CHANGELOG.md)

## Langue d’affichage et documentation hors ligne

Choisissez la langue d’affichage dans « Language / 言語 », tout en haut de l’Inspector. Ce choix s’applique à la fois à l’Inspector et aux menus VRChat générés. Renvoyez l’avatar pour modifier l’affichage dans le jeu.

Sans choix explicite, la langue de l’ordinateur est utilisée ; une langue non prise en charge est remplacée par l’anglais. Windows, macOS et Linux sont pris en charge. La dernière langue choisie est enregistrée dans EditorPrefs et réutilisée dans les autres projets du même utilisateur du système sur cet ordinateur. Tous les outils de poses et avatars utilisent la même langue. La modifier dans l’Inspector de n’importe quel outil met à jour le réglage commun ; les choix de langue propres aux avatars sont ignorés. Ce réglage n’est pas synchronisé avec d’autres ordinateurs. Le stockage de la licence reste inchangé. Le bouton de langue apparaît uniquement lors de la première confirmation d’installation si aucune langue n’est enregistrée. Les changements ultérieurs se font dans l’Inspector.

Choisissez la langue du README, de l’historique et du guide dans la [liste des langues](../index.html) fournie. Les liens du guide et de l’historique dans l’Inspector suivent également la langue sélectionnée. Les conditions d’utilisation originales et leurs traductions de référence restent disponibles séparément.

## Fonctions principales

- Mode photo : déplacez l’avatar jusqu’à 3m vers l’avant et réglez sa direction. 0 bit pour votre vue seulement, 16 bit pour montrer sa position et son orientation aux autres.
- Tête visible pendant les photos : empêche votre propre tête de disparaître à proximité, uniquement en Mode photo.
- Hauteur sol : déplace le corps entier, tête comprise, de 3m vers le haut ou le bas. 50% correspond à la hauteur initiale et d’origine, 0% à 3m plus bas et 100% à 3m plus haut. Ce réglage est distinct de « Hauteur pieds », qui déplace le côté des pieds sans changer la position de la tête.
- Se retourner : dans les poses allongées compatibles, roulez à gauche ou à droite en inclinant la tête.
- Respiration : anime la poitrine et d’autres parties du corps. Choisissez Aucun, Faible, Moyenne, Forte, Rapide ou Personnalisé pour chaque catégorie.
- Désactiver le balancement au repos de VRChat : réduit le balancement d’attente standard tout en conservant la respiration de l’outil et les autres mouvements personnalisés.
- Réduire les déformations liées à la rotation de la tête : limite les déformations après libération du cou lorsque son orientation diffère de la pose d’origine.
- Choix des fonctions : ajoutez uniquement les menus voulus et consultez la consommation des ExpressionParameters dans l’Inspector.
- Recherche, ajout groupé et réordonnancement des poses : recherche dans toutes les catégories, importation de plusieurs clips et choix de destination dans la liste.
- Aperçu simple dans la Scene : vérifiez immédiatement une pose avec « Aperçu » dans la liste.

- Ajustement automatique des membres (IK) : adapte leur position à la morphologie de l’avatar dans les poses compatibles. Vous pouvez l’activer par pose et intégrer son résultat dans une animation d’ajustement.

### Se retourner avec les poses fournies

Les poses sur le dos « Jambes tendues », « Relax » et « Un genou levé » ont des poses latérales de retournement prédéfinies. Elles sont respectivement basées sur la pose « 横向き寝 » (couchée de profil), « Sieste » et « Sieste de chat ».

Activez « Fonctions > Fonctions du menu > Se retourner », envoyez l’avatar, puis choisissez dans VRChat une pose compatible et « Se retourner ». Laissez le verrouillage du cou désactivé.

Pour rendre une pose compatible vous-même, activez « Poses > Détails > Activer le retournement » et affectez une animation à « Pose latérale de retournement ». Les poses utilisant cette fonction ne peuvent plus utiliser le réglage MotionTime ordinaire.

### Ajustement à la morphologie

L’ajustement automatique des membres fourni est disponible, mais toutes les poses n’ont pas besoin d’IK. Dans la fenêtre d’ajustement de l’animation, « Activer l'ajustement automatique des membres » agit globalement et « Activer l'IK pour cette pose » agit individuellement.

« Intégrer l'IK aux ajustements » enregistre le résultat automatique actuel dans une nouvelle animation d’ajustement et désactive l’IK de la pose concernée. Vous pouvez ensuite terminer à la main. Ce bouton nécessite l’ajustement automatique global et de la pose actifs, avec des réglages IK applicables.

« Configuration de l'avatar » propose aussi « Empêcher les genoux de se plier à l'envers » et le réglage détaillé « Flexion minimale du genou (degrés) ».

## Installation

1. Téléchargez les fichiers depuis la page du produit dans la boutique où vous l’avez acheté.
2. Importez le fichier fourni « 可愛いポーズツール.unitypackage » dans Unity et enregistrez la licence ainsi que le dépôt de packages.
3. Dans VCC ou ALCOM, ajoutez Kawaii Posing et Modular Avatar au projet Unity utilisé. Unisaki Posing System et NDMF sont aussi installés comme dépendances.
4. Dans la Hierarchy, faites un clic droit sur l’avatar cible et choisissez « Unisaki Studio > Ajouter Kawaii Posing ».
5. Sélectionnez l’objet Kawaii Posing ajouté dans l’avatar et réglez les fonctions et poses voulues dans l’Inspector.
6. Envoyez l’avatar normalement.

Environnement requis : Unity 2022.3, VRChat Avatars SDK 3.10.4 ou ultérieur, Modular Avatar 1.x à partir de 1.15.1 et NDMF 1.x à partir de 1.14.0. Mettez également à jour les dépendances nécessaires dans VCC ou ALCOM.

## Mise à jour depuis une ancienne version

Mettez à jour ensemble ce produit et Unisaki Posing System. Les réglages des outils déjà placés sont conservés. Vérifiez les fonctions et la consommation des ExpressionParameters dans l’Inspector ; si vous utilisiez le précalcul, cliquez sur « Actualiser le précalcul » avant de renvoyer l’avatar.

Depuis v3.1.0, les nouveaux ajouts utilisent tous le Prefab 「可愛いポーズ」 standard. En désactivant les options inutiles dans « Fonctions », une configuration minimale limitée au choix des poses utilise 8 bit. Un grand nombre de poses peut nécessiter des bits de sélection supplémentaires.

Les anciens Prefabs 8bit restent dans « Editor/Legacy » pour conserver les références des avatars et préréglages existants. Ne supprimez ni ne remplacez vos Prefabs existants. Le menu d’ajout de Unity n’affiche plus de version 8bit.

## Où trouver les réglages

| Onglet | Possibilités |
| --- | --- |
| Fonctions | Ajouts au menu du jeu, fonctions pratiques, réglages de respiration, icônes et consommation des ExpressionParameters |
| Poses | Choix des poses, détails, recherche, ajout groupé, réordonnancement, aperçu et ajustement de l’animation |
| Configuration de l'avatar | Corrections propres à l’avatar, genoux, importation des poses d’origine ou mouvements personnels et changement de préréglage |

Le lien d’ouverture des réglages déploie les détails sous la fonction concernée. La respiration se règle dans « Fonctions > Fonctions pratiques > Animer la respiration ».

« Utiliser les poses debout, accroupies et sur le ventre d'origine » importe automatiquement les poses déjà présentes dans l’avatar. Pour vos propres mouvements, ouvrez séparément les réglages d’importation et affectez chaque type, par exemple debout, accroupi (Crouching) ou couché sur le ventre (Prone).

Les préréglages sont au bas de « Configuration de l'avatar ». « Appliquer ce préréglage » remplace la configuration actuelle des poses : enregistrez vos ajustements avant de changer de préréglage.

### Consommation par fonction

- L’animation de respiration utilise 0 bit. Seul « Fonctions du menu > Respiration », qui permet de l’arrêter et de la relancer dans le jeu, utilise 1 bit pour synchroniser l’activation.
- Le Mode photo utilise 0 bit en vue locale uniquement. « Fonctions pratiques > Synchroniser le Mode photo » utilise 16 bit. « Garder la tête visible en Mode photo » utilise 0 bit.
- « Hauteur pieds » et « Hauteur sol » utilisent chacun 8 bit. Éloigner la hauteur du sol du centre déplace l’avatar verticalement ; revenir près de 50% termine la correction.
- « Se retourner » seul utilise 10 bit. Il partage 1 bit avec « Réduire les déformations liées à la rotation de la tête » : les deux ensemble utilisent donc aussi 10 bit.
- « Miroir » et « Sans gestes » utilisent chacun 1 bit.

Le total de l’Inspector concerne les outils de poses installés sur l’avatar. Il n’inclut pas les autres systèmes, comme les vêtements. Les réglages communs ne sont pas comptés plusieurs fois lorsque plusieurs outils de poses sont utilisés.

### Aperçu et édition des poses

« Aperçu » sur chaque entrée de « Poses » affiche la posture dans la Scene. Pour la modifier précisément, ouvrez « Ajustement de l'animation », ajustez-la avec l’aperçu, puis enregistrez.

L’aperçu simple n’exécute pas le build MA ou NDMF. Vérifiez aussi dans le résultat du build avant envoi les vêtements intégrés à ce moment et les corrections de contact avec le sol.

La loupe à gauche permet de chercher les poses par nom. Réordonnez-les en choisissant la destination dans « Détails > Ordre » ou avec les boutons haut et bas. Ajoutez plusieurs animations en les glissant dans la zone d’ajout ou avec « Importer les clips sélectionnés dans Project ».

« Actualiser les vignettes des poses » génère les images après une confirmation. « Générer les icônes des poses » rend les poses plus faciles à reconnaître dans le menu du jeu, mais augmente le temps de build à cause de la génération des images. Choisissez « Réduire la taille des icônes » pour limiter leur taille. Les icônes de poses ne sont pas générées pour Android.

## Commandes de base dans le jeu

- Choisissez les poses de chaque catégorie dans le menu Expressions. En VR, la hauteur de votre tête détermine le passage entre debout, accroupi, assis et allongé.
- En position allongée, l’orientation du visage fait passer du dos au ventre. Si les deux orientations ont une pose sélectionnée, vous pouvez aussi sauter sur place pour changer. Désactivez ce changement dans « Fonctions → Fonctions pratiques → Changer de pose allongée en sautant » de Unity si nécessaire (activé par défaut). Les seuils du menu de réglages déterminent les hauteurs de changement de catégorie.
- En mode bureau, utilisez C et Z pour changer de posture. Si Z ne vous allonge pas, augmentez le seuil de hauteur allongée dans le menu de réglages.
- Activez « Sans gestes » pour utiliser les mains définies dans la pose à la place des gestes de vos contrôleurs.
- « Hauteur pieds » ajuste le côté des pieds en conservant la position de la tête. « Hauteur sol » déplace tout le corps verticalement, tête comprise. Ils apparaissent dans cet ordre dans le menu de réglages.
- Avancez avec « Mode photo > Distance » pour que l’avatar vous fasse face. Faites-le pivoter avec « Direction », puis activez « Pieds fixes » au moment voulu. « Quitter photo » réinitialise distance et direction et déverrouille les pieds.
- « Respiration » est disponible si son animation est active. L’intensité se règle dans Unity ; le jeu permet de l’activer ou de la désactiver.

## Précalcul et avertissements

« Actualiser le précalcul » réutilise les données générées pour accélérer le build de l’avatar. Sans précalcul, le build ordinaire génère lui-même les données nécessaires.

Après une modification, « Vérifier les réglages » en haut de l’Inspector et les marques de la Hierarchy signalent les mises à jour nécessaires. « Réglages d'affichage des avertissements » se trouve dans « Vérifier les réglages ». Masquer ces messages ne corrige pas les problèmes et n’actualise pas les données générées.

## Précautions d’utilisation

- Le verrouillage de pose avec suivi du corps entier n’est pas pris en charge.
- La morphologie, les vêtements et les modifications de l’avatar peuvent nécessiter des ajustements supplémentaires.
- L’intégration peut être incorrecte avec des couches Base particulières ou d’autres systèmes de posture. Si les verrouillages fonctionnent mal, vérifiez aussi « Configuration de l'avatar > Intégrer les verrouillages de suivi aux autres outils ».
- Les corrections de déplacement et rotation du Mode photo et de hauteur du sol s’appliquent aussi aux mouvements standards ou personnels sans pose sélectionnée. Vérifiez dans le client VRChat le point de vue et le comportement après remplacement des mouvements standards.
- « Désactiver le balancement au repos de VRChat » agit sur l’attente standard. Cette fonction n’arrête pas les mouvements provenant de toutes les autres sources.

## Guide et assistance

Ouvrez le guide, l’assistance et l’historique dans « Aide / Historique » en haut de l’Inspector. Les fonctions communes sont aussi expliquées dans « Packages > Unisaki Posing System > README » de la fenêtre Project de Unity.

- [Manuel officiel](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Assistance](https://help.unisakistudio.jp/)

Pour signaler un problème, fournissez les versions de ce produit et de Unisaki Posing System, celles de Unity, VRChat SDK, Modular Avatar et NDMF, l’avatar utilisé, les étapes de reproduction et les erreurs de la Console.

## Distribution des préréglages

Informations concernant les données créées avec l’ajustement de l’animation.

Vous pouvez librement distribuer ou vendre les fichiers d’animation d’ajustement créés avec cette fonction,
ainsi que les préréglages créés avec ces fichiers affectés, sans demander l’autorisation de Unisaki Studio.
N’hésitez pas à les partager, notamment avec vos propres avatars ou sous forme de préréglages pour des avatars non fournis avec l’outil.

## Produits avec réglages d’intégration fournis

Les réglages d’intégration sont créés à notre initiative. Nous n’avons pas demandé l’autorisation des auteurs des produits concernés, estimant qu’elle n’était pas nécessaire.
Pour demander leur distribution ou l’arrêt de leur distribution, contactez-nous par message à la boutique.
L’intégration nécessite l’achat et le téléchargement du produit correspondant.
En cas de problème avec ces réglages, contactez notre boutique plutôt que les auteurs des autres produits.

« 可愛い座りツール »
https://yunisaki.booth.pm/items/3611536

« 添い寝ツール »
https://yunisaki.booth.pm/items/3670993

« 少女モーション集vol.1 », par ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

« VRC想定移動モーション（無料配布） », par カトのVRC道具屋
https://booth.pm/ja/items/1285101

« ごろ寝システムEX », par minminmart
https://minminmart.booth.pm/items/4233545

## Conditions d’utilisation

Cet outil est réservé aux personnes acceptant les conditions d’utilisation ci-dessous, rédigées avec la licence VN3.

[Conditions d’utilisation (japonais)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Le code source et les ressources de ce dépôt ne sont pas open source. L’achat légitime du produit et l’acceptation des conditions d’utilisation sont nécessaires.

[Conditions d’utilisation (anglais)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
