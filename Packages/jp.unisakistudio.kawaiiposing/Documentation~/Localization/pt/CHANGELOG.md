# Histórico de alterações

## [3.2.0] - Não lançado

### Adicionado

- Inspector, comandos de edição, diálogos de instalação, nomes de poses padrão e menus VRChat gerados em 30 idiomas.
- Idioma unificado entre Inspector e menu no jogo. Inicialmente utiliza o idioma do computador e partilha a última escolha com outros projetos do mesmo utilizador.
- README, histórico e manual offline abertos no idioma escolhido.
- Nomes das 128 poses padrão e descrições de todas as funções alinhados com a terminologia existente.

### Compatibilidade

- Mantidas definições existentes, nomes próprios, referências a recursos, identificadores de parâmetros e armazenamento da licença.

## [3.1.2] - 2026-11-09

- Fixação da cabeça em Definições → Fixação automática da cabeça de costas disponível mesmo sem Altura pés. Entradas perdidas regressam após atualização/compilação.
- Compatível com Unisaki Posing System 3.1.2; rosto para cima após levantar de bruços com correção da cabeça ativa corrigido.

Atualize Kawaii Posing para 3.1.2 com ALCOM / VCC; exige sistema comum 3.1.2. Se usava pré-cálculo, atualize-o, guarde e compile/envie novamente.

## [3.1.1] - 2026-11-08

- Altura chão e Virar aparecem nas Definições EX mesmo sem Espelhar.
- Virar correto em Pernas esticadas, Relaxado e Um joelho levantado após ordenação/eliminação/renomeação antiga, mesmo Unpack completo se identificável. Mantidas poses próprias, desativação intencional e laterais substituídas.
- Corrigidas breve posição de bruços na seleção e breve posição de costas ao saltar só com bruços escolhidos. Salto desativável em Funções → Funções práticas → Trocar poses deitadas pulando, inicialmente ativo.
- Referência recuperável do Animator Controller comum gera aviso e reconstrução; referências partilhadas conservadas.
- Prefab oficial adicionado mesmo existindo outro 「可愛いポーズ」 com o mesmo nome.
- Ao adicionar 添い寝ツール sem o produto necessário, indica o que instalar primeiro.

Em ALCOM / VCC, atualize Kawaii Posing e Unisaki Posing System ambos para 3.1.1. Se usava pré-cálculo, prima Atualizar pré-cálculo no 「可愛いポーズ」 da cena e guarde-a. Compile e envie novamente o avatar para refletir as alterações em VRChat.

## [3.1.0] - 2026-11-07

- IK automática em 53 das 85 poses conforme proporções.
- Pernas esticadas, Relaxado e Um joelho levantado compatíveis com Virar pela cabeça.
- Modo foto com posição/direção, sincronização e cabeça visível opcionais.
- Altura chão move corpo 3m acima/abaixo, separada dos pés.
- Respiração, supressão do balanço e correção do pescoço.
- Consumo/funções no Inspector, pesquisa, vários clips, ordem e pré-visualização na Scene.
- Mudança desktop em pé/agachado/sentado acelerada.
- Avisos de pré-cálculo, deslocação e limpeza melhorados.
- Compatível com sistema comum 3.1.0.

## [3.1.0-beta.2] - Beta aberto (2026-11-05)

- Beta aberto em GitHub Releases/VPM. IK adapta 53 das 85 poses às proporções.
- Pacote comum 3.1.0-beta.2 suportado; mudanças após pré-cálculo, deslocação no Inspector e pausas de limpeza melhoradas.

## [3.1.0-beta.1] - Beta aberto (2026-11-04)

- Compatível com Unisaki Posing System 3.1.0-beta.1.
- Mudança desktop normal com uma avaliação na compilação/pré-cálculo; VR e exceções mantêm percurso anterior.
- Pré-cálculos alpha.3 ou anteriores reconhecidos como por atualizar.
- Vista conservada ao mudar chão no Modo foto e restaurada à última altura.
- Melhorias até alpha.3 em importação automática, ajustes importados e Controllers refletidas.

## [3.1.0-alpha.2] - Teste fechado (2026-10-26)

### Correções e alterações

- Sistema comum atualizado a 3.1.0-alpha.2 com correções de depuração.
- Chão ampliado a 3m acima/abaixo; 50% original/inicial.
- Modo foto e chão também corrigem movimentos padrão/próprios sem seleção.
- Ajustes manuais, poses homónimas/iniciais e Virar em predefinições antigas corrigidos.

## [3.1.0-alpha.1] - Antes de publicar

### Adicionado

- IK automática conforme proporções adicionada.
- Ativação global/por pose e integração IK em ajustes.
- Pernas esticadas, Relaxado e Um joelho levantado com Virar pela cabeça.
- Opções de Virar e animação lateral por pose.
- Modo foto com avanço/rotação.
- Sincronização: 0 bit local, 16 bit sincronizados.
- Cabeça própria visível opcional no Modo foto.
- Altura chão eleva corpo e cabeça.
- Movimento/intensidade e menu de respiração.
- Supressão do balanço VRChat.
- Redução de deformação por pescoço.
- Prevenção de flexão inversa e mínimo de joelho.
- Ativação por função e consumo ExpressionParameters.
- Pré-visualização Scene, pesquisa, vários clips e ordem de destino.
- Histórico no Inspector.

### Alterações

- Inspector em 3 separadores: Funções, Poses, Configuração do avatar.
- Respiração, movimentos próprios e predefinições reorganizados.
- Menos animações duplicadas de Altura pés.
- Atualização de imagens com confirmação e avisos em Verificar configurações.
- Novas instalações 8bit retiradas em favor do Prefab normal, referências mantidas.
- Compatível com Unisaki Posing System 3.1.0-alpha.1; VRChat Avatars SDK mínimo 3.10.4.

### Correções

- Nomes a passarem para outra pose e detalhes a fecharem ao ordenar corrigidos.
- Pré-visualizações sobrepostas, posição errada e erros em certos avatares corrigidos.
- Atualização de avisos/pré-cálculo após alterações e erros de compilação corrigidos.

## [3.0.13] - 2026-09-22
- PosingSystem 3.0.17 corrige desvio horizontal por escala uniforme do avatar.
- Avisos de passos automáticos, pré-cálculo ausente e alterações ignoráveis separadamente ou juntos.
- Animações simples inadequadas excluídas da importação manual de locomoção.

## [3.0.12] - 2026-09-15
- Predefinição adicionada (ルリエ).

## [3.0.11] - 2026-09-09
- Predefinições adicionadas (メルヴィ, ミダリス).
- Substituição de movimentos de うらら corrigida.

## [3.0.10] - 2026-08-31
- PosingSystem 3.0.11 corrige pré-cálculo com NDMF recente e exceções da indicação de erros.

## [3.0.9] - 2026-08-29
- PosingSystem 3.0.10 alivia carregamento de predefinições e ícones Hierarchy.
- Pré-cálculo com vários sistemas no mesmo avatar corrigido.

## [3.0.8] - 2026-08-26
- PosingSystem 3.0.9 corrige Avatar de pré-visualização inválido após NDMF e `Avatar is null` em Play.

## [3.0.7] - 2026-08-18
- PosingSystem 3.0.8 corrige possível corrupção de poses na nova correção de altura.

## [3.0.6] - 2026-08-12
- Predefinições adicionadas (うらら, ウェンディ, カザリス, カプリィナ, キリサメ, シウシウ, ハンカ, フィユエ, プラム, マヨ, ミサキ, ラシューシャ, ルルネ).

## [3.0.5] - 2026-03-17
- Predefinições adicionadas (アズキ, あのめあ, イメリス, うささき, 京狐, ここあ, コロネ, サフィー, しずく, しらつめ, ソフィナ, ソラハ, デルタフレア, トラス, ナナセノワール, ナユ, ネメシス, フレア, プラチナ, 真央, 真冬, むんき, めいゆん, ヨル, ラスク, リーファ, りりか, 竜胆, ルゼブル, ヴェール).

## [3.0.4] - 2026-01-31
- Predefinições adicionadas (クマリ, イチゴ, エルシオン, ラムネ, リルモワ, サバラム, Lapwing).

## [3.0.3] - 2026-01-11
- Instalação/remoção de licença melhoradas.

## [3.0.2] - 2026-01-04
- Corrigido o processamento da licença nas versões Mac e Linux.

## [3.0.1] - 2025-12-28
- Predefinições adicionadas (セレスティア, まめひなた, しお, 愛莉, ライム, ショコラ, ミルフィ).

## [3.0.0] - 2025-12-28
- Pré-cálculo adicionado.
- Ajuste de animação adicionado.
- Predefinições adicionadas.
- Adição ao projeto por unitypackage.
- Predefinições adicionadas (マヌカ, しなの, 桔梗, 萌, ミルティナ, キプフェル, シフォン, ルミナ, エク, みみのこ).

## [2.2.5] - 2025-05-08
- Compatibilidade com certos sistemas corrigida.

## [2.2.4] - 2025-04-04
- Poses que não mudavam com certos avatares e ModularAvatar corrigidas.

## [2.2.3] - 2025-03-13
- Movimentos estranhos de avatares, como salto de 森羅, corrigidos.
- Valor inicial de Sem gestos incorreto em certos casos corrigido.

## [2.2.2] - 2025-03-06
- Erros em certos ambientes corrigidos.

## [2.2.1] - 2025-02-05
- Falha do Unity corrigida.
- Versão no nome da ferramenta em NDMF Console adicionada.

## [2.2.0] - 2025-02-02
- Adicionada opção Sem gestos para usar a forma das mãos da animação.
- Adicionados dados da forma das mãos a todas as poses.

## [2.1.6] - 2025-02-02
- Poses deformadas com certas ferramentas corrigidas.
- Erros dependentes das opções corrigidos.

## [2.1.5] - 2024-12-10
- Conflitos com certos sistemas resolvidos.
- Remoção de Unitypackage por botão.
- Prefabs de integração de 三点だいしゅきツール removidos após versão VCC.

## [2.1.4] - 2024-12-08
- Erros em certos avatares corrigidos.
- Fixação dos pés inutilizável por conflitos corrigida.
- Posturas a regressar ao padrão VRC no desktop corrigidas.

## [2.1.3] - 2024-12-01
- Mudança impossível com VRMode de tipo errado em avatares/sistemas corrigida.
- Conflitos de tipos de parâmetros mostrados em NDMF-Console.

## [2.1.2] - 2024-12-01
- Explicação em NDMF-Console quando erros externos causam erro no sistema durante compilação.
- Falhas de compilação em certos avatares corrigidas.
- Comportamento após carregar avatar melhorado.
- Processamento original de locomoção removido por impedir funcionamento em certos avatares.

## [2.1.1] - 2024-11-20
- Falha que impedia compilar corrigida.

## [2.1.0] - 2024-11-20
- Corrigidos pés e anca enterrados no desktop, permitindo todas as poses corretamente.
- Adicionada mudança de postura independente da altura da cabeça.
- Adicionado modo sem gerar ícones para enviar avatares Quest.
- Adicionados vários avisos de problemas no avatar.
- Resolvidos conflitos das fixações com AFK e bloqueios de braços de outras ferramentas.
- Adicionada fixação automática do pescoço de costas.
- ExpressionsMenu reorganizado: seleção de poses em pasta separada e fixações no nível principal.

## [2.0.0] - 2024-11-14
### Correções
- Pacote VPM para VCC.
- Versão 8bit a consumir 17bit corrigida.

## [1.15.0] - 2024-11-04
### Correções
- Erros e problemas corrigidos.

## [1.14.0] - 2024-07-05
### Correções
- Problemas com VRCFury corrigidos.

## [1.13.0] - 2024-04-11
### Correções
- Integração ごろ寝システムEX adicionada.

## [1.12.0] - 2024-03-31
### Correções
- Corrigida impossibilidade de usar a ferramenta conforme o estado de ExMenu.
- Adicionada função Espelhar às definições.
- Corrigida pose de gato.
- Adicionadas ５ poses deitadas de lado.

## [1.11.0] - 2024-03-12
### Correções
- Poses erradas com cabeça alta corrigidas.

## [1.10.0] - 2024-03-10
### Correções
- Poses em pé com 15 variantes.
- Pés a mexerem sozinhos em certos avatares/ambientes corrigidos.
- Versão ExpressionParameters8bit adicionada.

## [1.9.0] - 2024-03-05
### Correções
- Corrigidos pés a moverem-se involuntariamente em certos avatares.
- WriteDefaults uniformizados.
- Adicionadas ７ poses agachadas e ８ sentadas.

## [1.8.0] - 2024-02-25
### Correções
- Falha no envio com ModularAvatar1.9.0 ou posterior corrigida.
- ModualrAvatar1.9.0 ou posterior passa a ser obrigatório.

## [1.7.0] - 2024-02-23
### Correções
- Alteração dos limiares da altura da cabeça para cada postura adicionada.
- Poses/pés anormais ao saltar em certos avatares corrigidos.
- ExpressionParameter reduzido de 54 a 16bit.

## [1.6.0] - 2024-02-20
### Correções
- Impossibilidade de adotar poses sentadas em VR corrigida.

## [1.5.0] - 2024-02-18
### Correções
- Poses sentadas no desktop disponíveis mesmo mantendo C premido.

## [1.4.0] - 2024-02-17
### Correções
- Integração 添い寝 sem a integração 三点だいしゅき corrigida.
- Pés bloqueados ao saltar corrigidos.

## [1.3.0] - 2024-02-16
### Correções
- Quantidade anormal de VRCContactSender/Receiver configurados corrigida.

## [1.2.0] - 2024-02-16
### Correções
- Erro de compilação ao enviar corrigido.

## [1.1.0] - 2024-02-15
### Correções
- Valores padrão errados com vários Prefabs corrigidos.
- Configuração da integração 可愛い座り corrigida.

## [1.0.0] - 2024-02-14
### Lançamento
