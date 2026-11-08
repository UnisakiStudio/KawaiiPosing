# Historial de cambios

## [3.2.0] - Sin publicar

### Añadido

- Inspector, operaciones de edición, diálogos de instalación, nombres de poses estándar y menús VRChat generados disponibles en 30 idiomas.
- Selección de idioma unificada para Inspector y menú del juego. Inicialmente usa el idioma del ordenador y recuerda la última elección en otros proyectos del mismo usuario del sistema.
- Apertura del README, historial y manual sin conexión en el idioma elegido.
- Nombres de las 128 poses estándar y descripciones de funciones preparados con terminología coherente con la existente.

### Compatibilidad

- Se conservan configuración del avatar, nombres propios, referencias a recursos, identificadores de parámetros y almacenamiento de licencias.

## [3.1.2] - 2026-11-09

- Bloqueo de cabeza disponible en «Ajustes → Bloqueo automático de cabeza boca arriba» del menú EX aunque Altura pies esté desactivada. Entradas perdidas en versiones anteriores vuelven al actualizar y compilar.
- Compatible con Unisaki Posing System 3.1.2. Corregido rostro mirando arriba al levantarse desde boca abajo con la reducción de deformaciones por rotación de cabeza activa.

Actualiza Kawaii Posing a 3.1.2 con ALCOM / VCC; requiere Unisaki Posing System 3.1.2. Si usabas precálculo, actualízalo, guarda la escena y vuelve a compilar y subir.

## [3.1.1] - 2026-11-08

- Altura suelo y Darse vuelta activados aparecen en Ajustes del menú EX incluso sin Reflejar.
- Movimientos correctos conservados para Piernas extendidas, Relajado y Una rodilla arriba tras ordenar, eliminar, renombrar o Unpack completo si el origen es identificable. Poses propias, Darse vuelta desactivado intencionadamente y laterales sustituidas se conservan.
- Corregido el breve paso boca abajo al seleccionar el avatar en VRChat y el breve paso boca arriba al saltar con solo poses boca abajo elegidas. Desactiva el cambio en «Funciones → Funciones prácticas → Cambiar poses tumbadas al saltar» si lo prefieres; está activo inicialmente.
- Referencias perdidas recuperables del Animator Controller común provocan aviso y reconstrucción desde ajustes. Referencias entre avatares conservadas.
- El menú coloca el Prefab oficial aunque exista otro 「可愛いポーズ」 guardado con el mismo nombre.
- Al añadir 添い寝ツール se indica qué producto instalar antes si falta el necesario.

Actualiza Kawaii Posing y Unisaki Posing System a 3.1.1 con ALCOM / VCC. Si usabas precálculo, actualízalo en 「可愛いポーズ」 de la escena y guarda. Vuelve a compilar y subir para aplicar en VRChat.

## [3.1.0] - 2026-11-07

- Ajuste IK automático de proporciones en 53 de las 85 poses.
- Piernas extendidas, Relajado y Una rodilla arriba compatibles con Darse vuelta por cabeza.
- Modo foto con posición/dirección, sincronización y cabeza visible opcionales.
- Altura suelo desplaza el cuerpo hasta 3m arriba/abajo, independiente de Altura pies.
- Respiración, supresión del balanceo y reducción de deformaciones por cuello añadidas.
- Consumo y funciones en Inspector, búsqueda, importación múltiple, orden y vista previa en Scene.
- Cambio de pie/agachado/sentado acelerado en escritorio.
- Avisos de precálculo, desplazamiento y pausas de limpieza mejorados.
- Compatible con Unisaki Posing System 3.1.0.

## [3.1.0-beta.2] - Beta abierta (2026-11-05)

- Beta abierta iniciada en GitHub Releases y VPM. IK adapta extremidades en 53 de las 85 poses.
- Compatible con paquete común 3.1.0-beta.2. Mejorados cambios tras precálculo, desplazamiento del Inspector y pausas de limpieza.

## [3.1.0-beta.1] - Beta abierta (2026-11-04)

- Compatible con Unisaki Posing System 3.1.0-beta.1.
- Cambio normal de postura en escritorio con una evaluación para compilación y precálculo; VR y condiciones especiales mantienen la ruta anterior.
- Alpha.3 o anteriores reconocidos como pendientes de actualización del precálculo.
- Vista conservada al cambiar Altura suelo en Modo foto y restaurada al último valor al salir.
- Mejoras de importación automática, ajustes de movimientos y Controllers hasta alpha.3 incorporadas.

## [3.1.0-alpha.2] - Prueba cerrada (2026-10-26)

### Correcciones y cambios

- Sistema común actualizado a 3.1.0-alpha.2 con correcciones de depuración.
- Altura suelo ampliada a 3m arriba/abajo; 50% original e inicial.
- Modo foto y suelo también corrigen movimientos estándar o propios sin selección.
- Corregidos ajustes manuales, poses homónimas, poses iniciales y Darse vuelta en preajustes antiguos.

## [3.1.0-alpha.1] - Antes de publicar

### Añadido

- Ajuste automático IK de proporciones añadido.
- Activación global y por pose e integración IK en animaciones de ajuste.
- Piernas extendidas, Relajado y Una rodilla arriba compatibles con Darse vuelta por cabeza.
- Ajustes por pose y animación lateral para darse vuelta.
- Modo foto con avance y giro.
- Sincronización opcional: 0 bit local, 16 bit sincronizados.
- Cabeza propia visible en Modo foto opcional.
- Altura suelo para elevar todo el cuerpo y cabeza.
- Movimiento, intensidad y menú de respiración.
- Supresión del balanceo estándar de VRChat.
- Reducción de deformaciones por dirección del cuello.
- Prevención de flexión inversa y ángulo mínimo de rodilla.
- Activación por función y consumo de ExpressionParameters.
- Vista en Scene, búsqueda, importación múltiple y elección de posición de destino.
- Historial dentro del Inspector.

### Cambios

- Inspector en 3 pestañas: Funciones, Poses y Configuración del avatar.
- Reorganizados detalles de respiración, importación propia y preajustes.
- Reducidos duplicados de animaciones para Altura pies.
- Confirmación antes de actualizar miniaturas y avisos reunidos en Comprobar configuración.
- Menú de nuevos Prefabs 8bit eliminado a favor del normal configurable, conservando referencias.
- Compatible con Unisaki Posing System 3.1.0-alpha.1; SDK mínimo 3.10.4.

### Correcciones

- Corregidos nombres escritos en otra pose y detalles cerrados al ordenar.
- Corregidos solapamientos de vistas previas, posición desviada y errores de ciertos avatares.
- Corregidos avisos y precálculo tras cambios y algunos fallos de compilación.

## [3.0.13] - 2026-09-22
- Actualizado a PosingSystem 3.0.17 para corregir desplazamientos horizontales al cambiar uniformemente la escala del avatar.
- Avisos de pasos automáticos, precálculo ausente y cambios ignorables individualmente o juntos.
- Corregida importación de animaciones simples inadecuadas al importar locomoción manualmente.

## [3.0.12] - 2026-09-15
- Preajuste de avatar añadido (ルリエ).

## [3.0.11] - 2026-09-09
- Preajustes añadidos (メルヴィ, ミダリス).
- Corregida sustitución de movimiento del preajuste うらら.

## [3.0.10] - 2026-08-31
- Actualizado a PosingSystem 3.0.11 para corregir precálculo con NDMF reciente y excepciones de la pantalla de errores.

## [3.0.9] - 2026-08-29
- Actualizado a PosingSystem 3.0.10 para aligerar preajustes e iconos Hierarchy.
- Corregido precálculo con varios sistemas de poses en el mismo avatar.

## [3.0.8] - 2026-08-26
- Actualizado a PosingSystem 3.0.9 para corregir Avatar de vista previa invalidado por NDMF y `Avatar is null` en Play.

## [3.0.7] - 2026-08-18
- Actualizado a PosingSystem 3.0.8 para corregir posible corrupción al recalcular altura.

## [3.0.6] - 2026-08-12
- Preajustes añadidos (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Preajustes añadidos (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Preajustes añadidos (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Mejoradas instalación y eliminación de licencia.

## [3.0.2] - 2026-01-04
- Corregida licencia en Mac y Linux.

## [3.0.1] - 2025-12-28
- Preajustes añadidos (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Precálculo añadido.
- Ajuste de animación añadido.
- Preajustes añadidos.
- Instalación mediante unitypackage.
- Preajustes añadidos (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Resueltos problemas de compatibilidad con ciertos sistemas.

## [2.2.4] - 2025-04-04
- Corregido bloqueo del cambio de poses con ciertos avatares y versiones de ModularAvatar.

## [2.2.3] - 2025-03-13
- Corregidos movimientos extraños en avatares como el salto de 森羅.
- Corregido valor inicial a veces erróneo de Sin gestos.

## [2.2.2] - 2025-03-06
- Corregidos errores en algunos entornos.

## [2.2.1] - 2025-02-05
- Corregido cierre de Unity.
- Versión añadida al nombre en NDMF Console.

## [2.2.0] - 2025-02-02
- Sin gestos para usar las manos de animación añadido.
- Datos de manos añadidos a todas las poses.

## [2.1.6] - 2025-02-02
- Corregidas poses deformadas con ciertas herramientas.
- Corregidos errores dependientes de ajustes.

## [2.1.5] - 2024-12-10
- Conflictos con ciertos sistemas resueltos.
- Botón para retirar Unitypackage añadido.
- Prefabs de integración de 三点だいしゅきツール retirados tras publicar su versión VCC.

## [2.1.4] - 2024-12-08
- Corregidos errores en ciertos avatares.
- Corregido bloqueo de pies inutilizable por conflictos con sistemas o avatares.
- Corregida vuelta a posturas estándar VRC en escritorio.

## [2.1.3] - 2024-12-01
- Corregido cambio imposible con avatares o sistemas que usan VRMode con tipo incorrecto.
- Aviso en NDMF-Console de conflictos por tipos de parámetros diferentes.

## [2.1.2] - 2024-12-01
- Explicación en NDMF-Console cuando fallos de otras herramientas provocan errores en Unisaki Posing System al compilar.
- Corregidas compilaciones fallidas de ciertos avatares.
- Mejorado comportamiento tras cargar el avatar.
- Retirado procesamiento original de locomoción que impedía funcionar en algunos avatares.

## [2.1.1] - 2024-11-20
- Corregido fallo que impedía compilar.

## [2.1.0] - 2024-11-20
- Pies y cadera hundidos en escritorio corregidos para todas las poses.
- Cambio independiente de altura de cabeza.
- Modo sin iconos para avatares Quest.
- Avisos de problemas de avatar.
- Conflictos de bloqueo con AFK o brazos de otras herramientas resueltos.
- Bloqueo automático de cuello boca arriba.
- ExpressionsMenu reorganizado: selección de poses en carpeta y bloqueos en la raíz.

## [2.0.0] - 2024-11-14
### Correcciones
- Convertido a paquete VPM para VCC.
- Corregido consumo de 17bit en la versión 8bit.

## [1.15.0] - 2024-11-04
### Correcciones
- Errores y problemas corregidos.

## [1.14.0] - 2024-07-05
### Correcciones
- Problemas con VRCFury corregidos.

## [1.13.0] - 2024-04-11
### Correcciones
- Integración con ごろ寝システムEX añadida.

## [1.12.0] - 2024-03-31
### Correcciones
- Herramienta inutilizable según estado ExMenu corregida.
- Reflejo añadido a ajustes.
- Pose de gato corregida.
- ５ poses tumbadas laterales añadidas.

## [1.11.0] - 2024-03-12
### Correcciones
- Poses incorrectas con cabeza alta corregidas.

## [1.10.0] - 2024-03-10
### Correcciones
- Función de pie con 15 poses añadida.
- Pies moviéndose solos en ciertos avatares y entornos corregidos.
- Versión ExpressionParameters8bit añadida.

## [1.9.0] - 2024-03-05
### Correcciones
- Pies moviéndose solos corregidos en ciertos avatares.
- WriteDefaults unificados.
- ７ poses agachadas y ８ sentadas añadidas.

## [1.8.0] - 2024-02-25
### Correcciones
- Subida fallida con ModularAvatar1.9.0 o posterior corregida.
- ModualrAvatar1.9.0 o posterior ahora obligatorio.

## [1.7.0] - 2024-02-23
### Correcciones
- Umbrales de cabeza configurables por postura.
- Poses o pies incorrectos al saltar con ciertos avatares corregidos.
- ExpressionParameter reducido de 54 a 16bit.

## [1.6.0] - 2024-02-20
### Correcciones
- Imposibilidad de sentarse en VR corregida.

## [1.5.0] - 2024-02-18
### Correcciones
- Poses sentadas disponibles manteniendo C en escritorio.

## [1.4.0] - 2024-02-17
### Correcciones
- Integración 添い寝 sin 三点だいしゅき corregida.
- Pies bloqueados al saltar corregidos.

## [1.3.0] - 2024-02-16
### Correcciones
- Cantidad anormal de VRCContactSender/Receiver corregida.

## [1.2.0] - 2024-02-16
### Correcciones
- Error de compilación al subir corregido.

## [1.1.0] - 2024-02-15
### Correcciones
- Valores predeterminados incorrectos con varios Prefabs corregidos.
- Integración 可愛い座り corregida.

## [1.0.0] - 2024-02-14
### Lanzamiento
