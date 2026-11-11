# Kawaii Posing

Herramienta de poses para VRChat con posturas sentadas y tumbadas adorables, utilizables con seguimiento de 3 puntos o escritorio. Incluye 85 poses: 15 de pie, 20 agachadas, 17 sentadas, 16 boca abajo y 17 boca arriba.

Este README corresponde a v3.2.0 en desarrollo. La fecha oficial no está fijada. La versión instalada aparece arriba del Inspector.

- [Página del producto en BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Historial de cambios](CHANGELOG.md)

## Idioma de la interfaz y documentación sin conexión

Elige el idioma en «Language / 言語», arriba del Inspector. Una sola selección controla el Inspector y los menús VRChat generados. Vuelve a subir el avatar para cambiar el idioma dentro del juego.

Sin una selección explícita se usa el idioma del ordenador; si no está disponible, se utiliza inglés. Se admiten Windows, macOS y Linux. La última elección se guarda en EditorPrefs y se reutiliza en otros proyectos del mismo usuario del sistema en este ordenador. Todas las herramientas de poses y los avatares usan el mismo idioma. Cambiarlo en el Inspector de cualquier herramienta actualiza la preferencia común; se ignoran las elecciones de idioma de cada avatar. No se sincroniza con otros ordenadores. El almacenamiento de las licencias no cambia. El botón de idioma solo aparece en la confirmación inicial de instalación cuando no hay un idioma guardado. Los cambios posteriores se realizan en el Inspector.

Elige el idioma del README, historial y manual en la [lista de idiomas](../index.html) incluida. Los enlaces del Inspector al manual y los cambios también siguen esa selección. Las condiciones originales y sus traducciones de referencia siguen disponibles por separado.

## Funciones principales

- Modo foto: mueve el avatar hasta 3m hacia delante y cambia su dirección. 0 bit solo local, 16 bit para mostrar posición y dirección a los demás.
- Cabeza visible durante fotos: impide que desaparezca la cabeza cercana del propio avatar solo en Modo foto.
- Altura suelo: desplaza todo el cuerpo, cabeza incluida, 3m arriba o abajo. 50% original e inicial, 0% 3m debajo y 100% 3m encima. Es distinto de Altura pies, que mantiene la cabeza en su sitio.
- Darse vuelta: gira a ambos lados inclinando la cabeza en poses compatibles.
- Respiración: mueve pecho y otras partes; elige Ninguno, Bajo, Medio, Alto, Rápido o Personalizado por categoría.
- Desactivar el balanceo en reposo de VRChat: elimina el balanceo estándar conservando respiración y movimientos propios.
- Reducir deformaciones por la rotación de cabeza: limita deformaciones al liberar un cuello con dirección distinta de la pose original.
- Selección de funciones: añade solo menús deseados y comprueba ExpressionParameters en Inspector.
- Búsqueda, importación múltiple y orden: búsqueda transversal, varios clips y posición de destino.
- Vista previa sencilla en Scene: muestra la pose directamente desde «Vista previa» en la lista.

- Ajuste automático de extremidades (IK): adapta las posiciones a las proporciones en poses compatibles. Permite activar cada pose e integrar el resultado en una animación de ajuste.

### Darse vuelta con las poses incluidas

Las poses boca arriba «Piernas extendidas», «Relajado» y «Una rodilla arriba» ya tienen movimientos laterales. Sus movimientos para darse vuelta se basan, respectivamente, en la pose «横向き寝» (tumbada de lado), «Siesta» y «Siesta de gato».

Activa «Funciones > Funciones del menú > Darse vuelta», sube el avatar y selecciona la pose compatible y Darse vuelta en VRChat. Mantén el cuello desbloqueado.

Para configurarlo, activa «Poses > Detalles > Activar Darse vuelta» y asigna una animación a «Pose lateral para darse vuelta». No podrás usar el MotionTime normal para esa pose.

### Ajustar a las proporciones

Puedes usar el ajuste automático incluido, aunque no todas las poses necesitan IK. «Activar ajuste automático de extremidades» controla el conjunto y «Activar IK para esta pose» cada entrada.

«Integrar IK en los ajustes» escribe el resultado actual en una animación nueva y desactiva IK para esa pose. Después puedes retocarla a mano. Requiere ajuste global y de la pose activos y reglas IK aplicables.

«Configuración del avatar» también incluye «Evitar la flexión inversa de rodillas» y el detalle «Flexión mínima de rodilla (grados)».

## Instalación

1. Descarga los archivos desde la página del producto en la tienda de compra.
2. Importa «可愛いポーズツール.unitypackage» en Unity y registra licencia y repositorio.
3. En VCC o ALCOM añade Kawaii Posing y Modular Avatar al proyecto. Unisaki Posing System y NDMF se instalan como dependencias.
4. Haz clic derecho en el avatar de Hierarchy y elige «Unisaki Studio > Añadir Kawaii Posing».
5. Selecciona Kawaii Posing dentro del avatar y configura funciones y poses en Inspector.
6. Sube el avatar normalmente.

Requisitos: Unity 2022.3, VRChat Avatars SDK 3.10.4 o posterior, Modular Avatar 1.x desde 1.15.1 y NDMF 1.x desde 1.14.0. Actualiza los paquetes necesarios juntos con VCC o ALCOM.

## Actualizar desde versiones anteriores

Actualiza este producto y Unisaki Posing System juntos. La configuración existente se conserva. Revisa funciones y ExpressionParameters en Inspector; si usabas precálculo, pulsa «Actualizar precálculo» antes de volver a subir.

Desde v3.1.0, las instalaciones nuevas usan el Prefab normal 「可愛いポーズ」. Desactiva opciones innecesarias: la selección mínima de poses usa 8 bit. Muchas poses pueden necesitar bits adicionales.

Los antiguos Prefabs 8bit quedan en «Editor/Legacy» para preservar referencias de avatares y preajustes. No es necesario eliminarlos ni sustituirlos. El menú para añadir no muestra la versión 8bit.

## Dónde se configura

| Pestaña | Uso |
| --- | --- |
| Funciones | Menús del juego, funciones prácticas, respiración, iconos y consumo de ExpressionParameters |
| Poses | Selección, detalles, búsqueda, importación múltiple, orden, vista previa y ajuste de animación |
| Configuración del avatar | Correcciones propias y de rodillas, poses originales o movimientos propios y cambio de preajustes |

El enlace de ajustes abre los detalles debajo de cada opción. Respiración está en «Funciones > Funciones prácticas > Animar la respiración».

«Usar las poses originales de pie, agachado y boca abajo» importa automáticamente las posturas del avatar. Para movimientos propios abre los ajustes de importación separados y asigna cada tipo: de pie, agachado (Crouching), boca abajo (Prone), etc.

Los preajustes están al final de Configuración del avatar. «Aplicar este preajuste» reemplaza las poses actuales; guarda los retoques antes de cambiar.

### Consumo por función

- Respiración sola: 0 bit. El menú para detenerla y reanudarla, «Funciones del menú > Respiración», requiere 1 bit sincronizado.
- Modo foto local: 0 bit. «Funciones prácticas > Sincronizar el Modo foto»: 16 bit. Mantener la cabeza visible: 0 bit.
- Altura pies y Altura suelo: 8 bit cada una. Alejar el suelo del centro mueve verticalmente; volver cerca de 50% termina la corrección.
- Darse vuelta: 10 bit solo. Comparte 1 bit con la corrección por rotación de cabeza, de modo que ambos juntos siguen usando 10 bit.
- Reflejar y Sin gestos: 1 bit cada uno.

El total del Inspector corresponde a herramientas de poses, no a ropa u otros sistemas. Los ajustes comunes no se cuentan dos veces usando varias herramientas.

### Vista previa y edición

«Vista previa» de cada pose muestra la postura en Scene. Para retoques precisos abre «Ajuste de animación», edita mirando el resultado y guarda.

La vista sencilla no ejecuta MA o NDMF. Comprueba también el resultado de compilación antes de subir para ver ropa añadida y correcciones del suelo.

La lupa izquierda busca nombres. Ordena en «Detalles > Orden» o con botones arriba/abajo. Añade varios clips arrastrándolos o con «Importar clips seleccionados en Project».

«Actualizar miniaturas de poses» genera imágenes tras confirmar. «Generar iconos de poses» ayuda en el menú, pero alarga la compilación. Usa «Reducir el tamaño de los iconos» para ahorrar espacio. Android no genera iconos de poses.

## Controles básicos dentro del juego

- Elige poses por categoría en Expressions. En VR la altura de cabeza controla de pie, agachado, sentado y tumbado.
- La dirección del rostro decide boca arriba o abajo. Con ambas seleccionadas puedes saltar para alternar. Se desactiva en «Funciones → Funciones prácticas → Cambiar poses tumbadas al saltar» de Unity (activo inicialmente). Las alturas se regulan con los umbrales del menú.
- En escritorio usa C y Z; si Z no te tumba, aumenta el umbral de altura para tumbarse.
- Sin gestos usa las manos de la animación en vez de los gestos de los controladores.
- Altura pies conserva la cabeza; Altura suelo mueve el cuerpo entero. Aparecen en ese orden.
- Distancia en Modo foto avanza y orienta el avatar hacia ti. Dirección lo gira; activa Fijar pies cuando quieras. Salir de foto restaura distancia/dirección y libera los pies.
- Respiración requiere su animación activa. Intensidad en Unity y activación en el juego.

## Precálculo y advertencias

«Actualizar precálculo» reutiliza datos para acelerar la compilación. Sin precálculo, el proceso normal genera los datos necesarios.

Tras modificar ajustes, Comprobar configuración y las marcas de Hierarchy avisan de actualizaciones. Las preferencias de avisos están dentro del mismo recuadro. Ocultarlos no corrige problemas ni actualiza datos.

## Notas de uso

- No admite bloqueo de poses con seguimiento de cuerpo completo.
- Proporciones, ropa y modificaciones pueden necesitar retoques.
- Capas Base especiales u otras herramientas pueden no integrarse bien. Revisa «Configuración del avatar > Integrar bloqueos de seguimiento con otras herramientas» si fallan los bloqueos.
- Movimiento y giro del Modo foto y Altura suelo también corrigen movimientos estándar o propios sin selección. Verifica vista y movimientos reemplazados en el cliente VRChat.
- Desactivar el balanceo de VRChat solo afecta al reposo estándar, no a todas las otras causas.

## Manual y asistencia

Abre manual, asistencia y cambios desde «Ayuda / Cambios» arriba del Inspector. Las funciones comunes también se explican en «Packages > Unisaki Posing System > README» de Project.

- [Manual oficial](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Asistencia](https://help.unisakistudio.jp/)

Al informar de fallos, incluye versiones del producto, Unisaki Posing System, Unity, VRChat SDK, Modular Avatar y NDMF, el avatar, los pasos exactos y el error de Console.

## Distribución de preajustes

Información sobre datos creados con el ajuste de animación.

Puedes distribuir y vender libremente los archivos de animación de ajuste creados con esta función
y los preajustes configurados con ellos, sin solicitar permiso a Unisaki Studio.
Compártelos, por ejemplo, con tus avatares o como preajustes de avatares no incluidos.

## Productos con integración incluida

Nuestro negocio creó unilateralmente los ajustes de integración. No solicitamos permiso a los autores porque consideramos que no era necesario.
Solicita su distribución o retirada mediante mensajes a la tienda.
La integración requiere comprar y descargar el producto correspondiente.
Si hay problemas con estos ajustes, contacta con nuestra tienda y no con los autores de los otros productos.

«可愛い座りツール»
https://yunisaki.booth.pm/items/3611536

«添い寝ツール»
https://yunisaki.booth.pm/items/3670993

«少女モーション集vol.1», de ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

«VRC想定移動モーション（無料配布）», de カトのVRC道具屋
https://booth.pm/ja/items/1285101

«ごろ寝システムEX», de minminmart
https://minminmart.booth.pm/items/4233545

## Condiciones de uso

Esta herramienta solo puede usarse aceptando las siguientes condiciones, elaboradas con la licencia VN3.

[Condiciones de uso (japonés)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

Código y recursos de este repositorio no son de código abierto. Se exige compra legítima y aceptación de las condiciones.

[Condiciones de uso (inglés)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
