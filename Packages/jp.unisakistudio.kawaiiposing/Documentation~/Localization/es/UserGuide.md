# Kawaii Posing — Manual de usuario en español

Kawaii Posing incluye 85 poses para escritorio y VR de tres puntos: 15 de pie, 20 agachadas o en silla, 17 sentadas en el suelo, 17 boca arriba y 16 boca abajo.

Esta guía cubre instalación, configuración del avatar, controles VRChat, edición, actualizaciones y solución de problemas. El ZIP comprado incluye `START_HERE.html` para acceder rápidamente a la instalación.

## Antes de empezar

- Usa un proyecto de **avatar** VRChat en Unity 2022.3 creado o gestionado con VRChat Creator Companion (VCC) o ALCOM.
- Paquetes necesarios: VRChat Avatars SDK 3.10.4 o posterior; Modular Avatar 1.x desde 1.15.1; NDMF 1.x desde 1.14.0.
- Para avatares Humanoid en escritorio y VR de tres puntos (visor y dos controladores). No admite bloqueo de poses con seguimiento de cuerpo completo activo.
- Haz copia de seguridad antes de instalar o actualizar y resuelve primero los errores de compilación pendientes.
- El instalador descarga producto y dependencias desde sus repositorios. Requiere Internet. Modelos de avatar, VRChat SDK, Modular Avatar y NDMF no están incluidos.

## 1. Instalar licencia y producto

1. Extrae todo el ZIP a una carpeta normal fuera del proyecto Unity.
2. Abre el proyecto y carga `Installer/KawaiiPosing_Installer.unitypackage` mediante **Assets > Import Package > Custom Package**, o abre el archivo con Unity.
3. Lee las confirmaciones de importación e instalación. La de licencia indica cuáles se instalarán. Usa **Idioma…** o **言語...** para cambiar el idioma del instalador.
4. Confirma la licencia. También cubre Unisaki Posing System usado por el producto. Puede ofrecer eliminar sus archivos de instalación, sin quitar la licencia instalada.
5. Revisa la confirmación de paquetes: muestra paquetes y repositorios a añadir y archivos o carpetas antiguos propuestos para borrar. Continúa si corresponden a lo esperado.
6. Espera importación y compilación. Si no se instalan automáticamente, abre VCC o ALCOM y añade **Kawaii Posing** y **Modular Avatar**. **Unisaki Posing System** y **NDMF** son dependencias. `Optional-VCC-Links` contiene accesos originales a repositorios para usuarios Windows de VCC.
7. Si cancelaste, reimporta el instalador cuando quieras continuar. También puedes usar su comando de licencia en **Tools > Unisaki Studio** mientras siga el activador. En versiones antiguas es **ゆにさきスタジオ**.

### Qué instala esta descarga

**Kawaii Posing 3.2.0 con Unisaki Posing System 3.2.0.** Está en desarrollo y aún no se ha publicado. Añade diálogos, Inspector y menús Unity, nombres de poses, menús del juego y documentación sin conexión en treinta idiomas. No hay fecha fijada. Cambia el idioma arriba del Inspector. Tras publicarse, el instalador descargará estas versiones y dependencias compatibles desde VPM. Preparar una versión localmente no publica paquetes.

Kawaii Posing incluye biblioteca de poses, configuración y preajustes de avatar. El instalador activa la licencia local existente; no necesita un nuevo campo de clave Gumroad. Nunca publiques archivos del instalador ni datos de licencia en solicitudes públicas de ayuda.

El idioma se guarda en Unity EditorPrefs para el usuario del sistema actual y se comparte entre proyectos del ordenador. Sin preferencia usa el idioma del sistema, o inglés si no está soportado. Las licencias conservan su almacenamiento: registro `Software/UnisakiStudio` del usuario en Windows y archivos por usuario en macOS/Linux. Cambiar idioma no elimina licencias. Todas las herramientas de poses y los avatares usan el mismo idioma. Cambiarlo en el Inspector de cualquier herramienta actualiza la preferencia común; se ignoran las elecciones de idioma de cada avatar. El botón de idioma solo aparece en la confirmación inicial de instalación cuando no hay un idioma guardado. Los cambios posteriores se realizan en el Inspector.

## 2. Añadir la herramienta a un avatar

1. En **Hierarchy**, selecciona el avatar con **VRC Avatar Descriptor** o un hijo. Usa un avatar de escena, no el recurso Prefab de Project ni el modo Prefab.
2. Clic derecho y **Unisaki Studio > Añadir Kawaii Posing**. Si los menús están en japonés: **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. Se añade al avatar; su nombre guardado puede seguir siendo **可愛いポーズ** aunque se traduzcan las etiquetas.
4. Aplica un preajuste compatible si aparece. Si no, abre **Configuración del avatar** y elige uno o ajusta las poses manualmente.
5. Puede ofrecer precalcular. Es opcional: la compilación normal genera los datos. Reutilizar precálculos reduce tiempos posteriores.
6. Selecciona la herramienta, elige poses y funciones y sube normalmente desde VRChat SDK.

### Idioma y etiquetas conocidas

Esta versión ofrece **Language / 言語** arriba del Inspector. Una elección controla Inspector y menú generado. El avatar guarda el idioma y se recuerda la última selección para otras herramientas y proyectos de este ordenador. Vuelve a subir para cambiar la lengua visible en VRChat.

Usa esta tabla al seguir tutoriales japoneses antiguos. La versión incluye selector, Inspector, nombres estándar y menús en los 30 idiomas.

| Español | Etiqueta japonesa en versiones anteriores |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funciones | 機能 |
| Poses | ポーズ一覧 |
| Configuración del avatar | アバター調整 |
| Abrir ajustes | 設定を開く |
| Actualizar precálculo | プレビルドを更新 |
| Comprobar configuración | 設定の確認 |
| Vista previa | プレビュー |
| Ajuste de animación | アニメーション調整 |
| Recargar | 再読込 |

Inspector, diálogos de edición/instalación, nombres estándar y menús generados están traducidos a los 30 idiomas. README, historial y manual sin conexión están disponibles en cada idioma. Nombres de avatar, objetos guardados, poses propias, archivos e identificadores internos pueden conservar su escritura original.

Las [referencias rápidas en 30 idiomas](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) explican funciones y nombres estándar. Son referencias breves; usa el índice de idiomas para la documentación completa.

## 3. Elegir poses y funciones

El Inspector tiene tres pestañas principales:

| Pestaña | Uso |
| --- | --- |
| **Funciones** | Controles del menú, comportamientos opcionales, respiración, iconos y consumo de parámetros. |
| **Poses** | Poses activas, categorías/búsqueda, orden, animaciones nuevas, vista previa, detalles y ajuste. |
| **Configuración del avatar** | Correcciones propias y de rodillas, importación original o personalizada y preajustes. |

Activa solo los menús que pienses usar. Añadir **Reflejar** permite conmutarlo en VRChat; no obliga a mantener todas las poses reflejadas.

Kawaii Posing incluye preajustes e IK compatible. Tres poses boca arriba ya tienen animaciones laterales: **Piernas extendidas (足伸ばし)**, **Relajado (リラックス)** y **Una rodilla arriba (膝立て)**. Usa el preajuste apropiado y revisa Darse vuelta en cada pose si modificaste o reemplazaste estas entradas.

### Preajustes y adaptación

Están al final de **Configuración del avatar**. Busca por nombre y aplica uno para reemplazar las poses actuales. Guarda o haz copia antes. Un preajuste es un punto de partida; proporciones, ropa y modificaciones pueden necesitar correcciones manuales.

**Ajuste de animación** permite ver y editar cuerpo y extremidades. Guarda desde esa ventana al terminar. El ajuste automático de manos y pies (IK) se puede activar globalmente y por pose donde esté soportado. Integrar el resultado actual crea una animación y desactiva IK para permitir retoques; conserva el clip fuente.

**Evitar la flexión inversa de rodillas** tiene ajustes adicionales, como flexión mínima. Las correcciones propias del avatar requieren datos y algunas no se pueden combinar con IK.

### Movimientos originales y propios

**Usar las poses originales de pie, agachado y boca abajo** detecta Base durante generación. **Usar tus propios movimientos** abre la importación separada por tipo. Elige uno por tipo; las asignaciones manuales tienen prioridad.

La importación automática actúa sobre la copia de compilación. No escribe animaciones detectadas en la lista manual ni cambia los Controllers originales. Retira una asignación manual para volver a detectar ese tipo. Base personalizada y otros sistemas pueden requerir ajustes individuales.

## 4. Usar en VRChat

Abre **Expressions** y entra en **Kawaii Posing**. Elige una pose en cada categoría deseada. Seleccionar una pose y una función son acciones separadas.

- **VR de tres puntos:** baja o sube la cabeza para cambiar entre de pie, agachado/silla, sentado en el suelo y tumbado. Ajusta umbrales si cambia demasiado pronto o tarde.
- **Escritorio:** **C** para agacharte y **Z** para tumbarte. Si Z deja sentado, aumenta el umbral de altura para tumbarse.
- **Boca arriba/abajo:** decide la dirección del rostro. Con ambas elegidas puedes alternar saltando. Se desactiva en **Funciones > Funciones prácticas** de Unity sin consumo sincronizado adicional.
- **Bloqueos:** fija cabeza, brazos o pies cuando necesites. Desactiva gestos para usar manos de la pose.
- **Reflejar:** invierte la pose para mirar a un amigo o ajustar la composición.

### Altura pies y Altura suelo

**Altura pies** ajusta los pies sin mover la cabeza. Úsalo si flotan o se hunden con la cabeza ya bien situada.

**Altura suelo** mueve todo el cuerpo, cabeza incluida. Sirve para sofá, cama o superficies elevadas, incluso sin collider. En el control centrado actual, **50% es la altura original**, 0% son 3 m debajo y 100% son 3 m encima. Vuelve cerca de 50% para terminar. Versiones antiguas pueden funcionar distinto; comprueba la versión y actualiza sistema común y producto juntos.

### Modo foto

Activa **Modo foto** en Unity antes de subir. En VRChat elige pose, avanza hasta 3 m con **Distancia** y gira con **Dirección**. Fijar pies es opcional mientras encuadras. **Salir de foto** restaura distancia y rotación y libera los pies.

Modo foto es local por defecto. Activa **Sincronizar el Modo foto** en Unity antes de subir para que otros vean posición y giro: usa 16 bits sincronizados. **Mantener la cabeza visible en Modo foto** solo afecta a tu vista y no añade bits.

### Respiración y Darse vuelta

Ajusta la respiración por categoría en **Funciones > Funciones prácticas > Animar la respiración**. Elige Ninguno, Bajo, Medio, Alto, Rápido o animación personalizada. Movimiento solo sin bits; interruptor de menú con 1 bit.

Darse vuelta necesita una pose tumbada compatible y la entrada **Darse vuelta**. Actívalo en la pose y añade animación lateral cuando corresponda. En VRChat elige la pose, actívalo y libera cabeza/cuello. La inclinación lateral controla el giro. MotionTime normal no está disponible mientras se usa.

Las tres poses estándar boca arriba citadas incluyen movimientos laterales. Las demás necesitan animación y ajustes apropiados. Preajustes importados o propios pueden tener asignaciones distintas.

## 5. Editar, añadir y previsualizar

En **Poses**, elige categoría o búsqueda. Busca nombres japoneses originales o traducciones. Abre **Detalles** para animación, icono, orden y tiempo.

Arrastra varios clips a la zona de adición o selecciónalos en Project y usa el comando de importación seleccionada. Se quitan duplicados del mismo clip. Cambia destino en Detalles o con controles arriba/abajo.

**Vista previa** muestra la pose en Scene sin abrir la ventana completa. No ejecuta Modular Avatar ni NDMF; revisa ropa, corrección del suelo y otras funciones en el avatar compilado final.

Los iconos del avatar ayudan a reconocer poses, pero tardan y pueden ocupar más datos. Reduce resolución para ahorrar. Android no genera iconos. Regenéralos tras cambiar avatar o ropa si hace falta.

## 6. Memoria de parámetros

El Inspector muestra el consumo de herramientas de poses, no el avatar completo. Ropa y otros sistemas pueden gastar más. Ajustes compartidos no se cuentan dos veces. Muchas poses adicionales pueden necesitar más bits de selección.

| Función | Bits sincronizados adicionales |
| --- | ---: |
| Selección de poses, mínimo estándar | 8 |
| Reflejar | 1 |
| Sin gestos | 1 |
| Animación de respiración | 0 |
| Interruptor de respiración | 1 |
| Altura pies | 8 |
| Altura suelo | 8 |
| Modo foto solo local | 0 |
| Sincronizar el Modo foto | 16 |
| Mantener la cabeza visible en Modo foto | 0 |
| Desactivar el balanceo en reposo de VRChat | 0 |
| Darse vuelta | 10 |

Darse vuelta comparte 1 bit con la corrección por dirección del cuello: ambas funciones siguen usando 10 bits en total. La cifra de tu versión instalada es la referencia práctica para la configuración seleccionada.

## 7. Actualizar y precalcular

1. Haz copia del proyecto y guarda la escena.
2. Actualiza **Kawaii Posing** y **Unisaki Posing System** juntos en VCC o ALCOM, manteniendo SDK, Modular Avatar y NDMF compatibles.
3. Espera la compilación y revisa poses, ajustes y consumo de la herramienta instalada.
4. Si usas precálculos, pulsa **Actualizar precálculo** y sube de nuevo.

Se conservan los ajustes. Los antiguos Prefabs 8-bit siguen por compatibilidad, sin exigir borrar o reemplazar referencias. Las nuevas instalaciones usan el normal y permiten desactivar funciones para ahorrar parámetros.

Un aviso de precálculo obsoleto indica cambios desde que se generó la caché. Actualizar regenera esos datos. Ocultar no actualiza ni resuelve la causa. La compilación normal genera lo necesario sin precalcular manualmente cada vez.

## 8. Solución de problemas

| Síntoma | Qué comprobar |
| --- | --- |
| No aparece el menú para añadir | Instala producto **y** Unisaki Posing System y resuelve errores de Console. El instalador de licencia solo no es la biblioteca. |
| Instalador cancelado o archivos retirados | Reimporta el instalador comprado y relee las confirmaciones. |
| Licencia ausente en otro proyecto | Importa con el mismo usuario del sistema. Si cambiaste de ordenador/cuenta, instala allí la licencia. El idioma no se transfiere automáticamente entre equipos. |
| No hay poses en VRChat | Añade bajo el avatar correcto de escena, activa poses, revisa avisos y sube ese avatar. Comprueba SDK y otras herramientas. |
| Z no permite tumbarse | Aumenta el umbral de altura en ajustes del juego. |
| Manos o rodillas desalineadas | Prueba el preajuste adecuado, IK compatible y/o Ajuste de animación. Revisa ropa en el resultado final. |
| Darse vuelta no funciona | Usa pose compatible, activa ajuste y menú y libera cabeza/cuello. Prueba primero una de las tres poses estándar compatibles. |
| Otros no ven movimiento foto | Activa **Sincronizar el Modo foto** en Unity, comprueba consumo y sube de nuevo. |
| Idioma solo cambia en Unity | Vuelve a subir. Comprueba el selector único superior en versiones localizadas. |
| Errores de compilación/precálculo | Lee el **primer** error relevante. Guarda copia de escena, actualiza o reinstala producto y sistema con VCC/ALCOM y contacta si persiste. Conserva objetos ajustados y GeneratedResources salvo instrucciones específicas de recuperación. |

Para asistencia incluye versiones de producto/sistema, Unity/SDK/Modular Avatar/NDMF, avatar, pasos exactos y error relevante. Retira archivos privados, contenido de instaladores, licencias y datos de cuenta de mensajes públicos.

- [Asistencia](https://help.unisakistudio.jp/)
- [Manual ilustrado online (japonés)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Página en Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licencias y créditos

Se incluye una [traducción inglesa de referencia del acuerdo](../../Terms.en.html) junto al original japonés.

Lee las condiciones originales del producto y sistema junto al README o en `Licenses` del ZIP. El acuerdo inglés de Unisaki Posing System es una traducción de referencia existente para ese sistema; el acuerdo japonés del producto se incluye aparte. El manual no modifica acuerdos ni concede derechos adicionales. Consulta a asistencia sobre uso o redistribución.

El instalador incluye **VPMPackageAutoInstaller** modificado, de **anatawa12**, con **SimpleJson** y **semver.net**. Avisos de copyright y licencias MIT están en `ThirdPartyNotices.txt` del ZIP. Biblioteca y otros recursos conservan sus licencias de producto.
