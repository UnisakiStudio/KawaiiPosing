# Kawaii Posing — Manual em português do Brasil

Kawaii Posing oferece 85 poses para desktop e VR de três pontos: 15 em pé, 20 agachadas/em cadeira, 17 sentadas no chão, 17 de costas e 16 de bruços.

Este manual cobre instalação, configuração do avatar, controles VRChat, edição de poses, atualizações e resolução de problemas. O ZIP comprado inclui `START_HERE.html` para chegar mais depressa à instalação.

## Antes de começar

- Utilize um projeto de **avatar** VRChat no Unity 2022.3, criado ou gerenciado com VRChat Creator Companion (VCC) ou ALCOM.
- Pacotes necessários: VRChat Avatars SDK 3.10.4 ou posterior; Modular Avatar 1.x desde 1.15.1; NDMF 1.x desde 1.14.0.
- Para Humanoid em desktop e VR de três pontos (um visor e dois controladores). Fixar poses com rastreamento de corpo inteiro ativo não é suportado.
- Faça cópia de segurança antes de instalar/atualizar e resolva primeiro erros de compilação existentes.
- O instalador baixa produto e dependências dos seus repositórios. É necessária Internet. Modelos de avatar, VRChat SDK, Modular Avatar e NDMF não estão incluídos no ZIP.

## 1. Instalar licença e produto

1. Extraia todo o ZIP para uma pasta normal fora do projeto Unity.
2. Abra o projeto desejado e importe `Installer/KawaiiPosing_Installer.unitypackage` em **Assets > Import Package > Custom Package**, ou abra o arquivo com Unity.
3. Leia pedidos de importação/instalação. A confirmação da licença explica as licenças a instalar. Use **Idioma…** ou **言語...** em um diálogo para mudar o idioma.
4. Confirme a licença, que também cobre Unisaki Posing System. O instalador pode depois oferecer remover os próprios arquivos; isto não remove a licença instalada.
5. Reveja a confirmação automática: pacotes/repositórios a adicionar e arquivos/pastas antigos propostos para remoção. Continue se forem os pretendidos.
6. Aguarde importação e compilação. Se não terminar automaticamente, abra o projeto em VCC ou ALCOM e adicione **Kawaii Posing** e **Modular Avatar**. **Unisaki Posing System** e **NDMF** são dependências. `Optional-VCC-Links` contém atalhos originais dos repositórios para VCC no Windows.
7. Se cancelou, importe novamente quando estiver preparado. Enquanto existir o ativador, também pode usar o comando de instalação de licença em **Tools > Unisaki Studio**. Nas versões antigas chama-se **ゆにさきスタジオ**.

### O que este download instala

**Kawaii Posing 3.2.0 com Unisaki Posing System 3.2.0.** Está em desenvolvimento e ainda não foi lançado. Acrescenta diálogos de instalação, Inspector/menus Unity, nomes padrão, menus no jogo e documentação offline em trinta idiomas. Não há data definida. Escolha o idioma no topo do Inspector. Após publicação, o instalador baixa essas versões e dependências compatíveis por VPM. Preparação local não publica pacotes.

Kawaii Posing inclui biblioteca de poses, ferramentas de configuração e predefinições do avatar. O instalador ativa a licença local existente; não exige novo campo de chave Gumroad. Não publique arquivos do instalador ou dados de licença em pedidos públicos de suporte.

O idioma é salvo em Unity EditorPrefs para o usuário atual e compartilhado entre projetos deste computador. Sem preferência segue o sistema, usando inglês se não suportado. Licenças mantêm registro `Software/UnisakiStudio` do usuário no Windows e arquivos por usuário no macOS/Linux. Mudar idioma não apaga licença.

## 2. Adicionar ao avatar

1. Na **Hierarchy**, selecione o avatar com **VRC Avatar Descriptor** ou um descendente. Use um avatar na cena, não o recurso Prefab no Project nem modo Prefab.
2. Clique com o botão direito e escolha **Unisaki Studio > Adicionar Kawaii Posing**. Com menus japoneses, use **ゆにさきスタジオ > 可愛いポーズツール追加**.
3. É adicionado dentro do avatar; o nome salvo pode continuar **可愛いポーズ** mesmo com rótulos traduzidos.
4. Aplique a predefinição compatível oferecida. Caso contrário abra **Configuração do avatar** e escolha outra ou ajuste manualmente.
5. O pré-cálculo oferecido é opcional: a compilação normal gera os dados. Reutilizá-lo reduz tempos seguintes.
6. Selecione a ferramenta, escolha poses/funções e envie normalmente pelo VRChat SDK.

### Idioma e rótulos conhecidos

Esta versão oferece **Language / 言語** no topo. A escolha controla Inspector e menu gerado. O avatar salva o idioma, lembrando a última seleção para ferramentas/projetos do computador. Envie novamente para alterar o idioma visto no VRChat.

Use a tabela ao seguir tutoriais japoneses antigos. Esta versão tem seletor, Inspector, nomes padrão e menus nos 30 idiomas.

| Português (Brasil) | Rótulo japonês nas versões antigas |
| --- | --- |
| Unisaki Studio | ゆにさきスタジオ |
| Funções | 機能 |
| Poses | ポーズ一覧 |
| Configuração do avatar | アバター調整 |
| Abrir configurações | 設定を開く |
| Atualizar pré-cálculo | プレビルドを更新 |
| Verificar configurações | 設定の確認 |
| Prévia | プレビュー |
| Ajuste de animação | アニメーション調整 |
| Recarregar | 再読込 |

Inspector, diálogos de edição/instalação, nomes padrão e menus gerados estão traduzidos nos 30 idiomas. README, histórico e manual offline estão disponíveis em cada um. Nomes de avatar, objetos salvos, poses próprias, arquivos e identificadores internos podem conservar a escrita original.

As [referências rápidas em 30 idiomas](../../../../jp.unisakistudio.posingsystem/Documentation~/QuickReference/index.html) explicam funções e nomes padrão. São referências breves; use o índice de idiomas para documentação completa.

## 3. Escolher poses e funções

O Inspector tem três separadores principais:

| Separador | Finalidade |
| --- | --- |
| **Funções** | Menus no jogo, comportamentos opcionais, respiração, ícones e parâmetros. |
| **Poses** | Poses ativas, categoria/pesquisa, ordem, animações novas, prévia, detalhes e ajuste. |
| **Configuração do avatar** | Correções próprias/joelhos, movimentos originais ou próprios e predefinições. |

Ative só os controles de menu que pretende usar. **Espelhar** no menu permite alternar o efeito no VRChat, sem obrigar todas as poses a ficarem espelhadas.

Kawaii Posing inclui predefinições e IK compatível. Três poses de costas já têm movimentos laterais: **Pernas esticadas (足伸ばし)**, **Relaxado (リラックス)** e **Um joelho levantado (膝立て)**. Use a predefinição correspondente e reveja Virar em cada pose se a editou ou substituiu.

### Predefinições e adaptação

As predefinições estão no fim de **Configuração do avatar**. Pesquise o nome do avatar e aplique uma para substituir as poses atuais. Salve ou faça cópia dos ajustes primeiro. Uma predefinição é um ponto de partida: proporções, roupa e alterações podem exigir correções manuais.

**Ajuste de animação** mostra e edita corpo/membros. Salve a animação na janela quando terminar. IK de mãos e pés é global ou por pose quando suportada. Incorporar o resultado cria animação de ajuste e desativa IK para aperfeiçoamento manual; o clip fonte permanece.

**Impedir flexão inversa dos joelhos** tem opções como ângulo mínimo. Correções específicas exigem dados correspondentes e algumas não são combináveis com IK.

### Movimentos originais e próprios

**Usar poses originais em pé, agachado e de bruços** detecta movimentos de Base na geração. **Usar seus próprios movimentos** abre importação separada por tipo. Escolha um por tipo; atribuições manuais têm prioridade.

A importação automática afeta a cópia de compilação, sem escrever na lista manual da cena nem mudar Controllers originais. Remova a substituição manual para voltar a detectar o tipo. Base personalizada e outros sistemas de locomoção podem precisar de ajustes individuais.

## 4. Utilizar no VRChat

Abra **Expressions** e **Kawaii Posing**. Escolha uma pose por categoria desejada. Selecionar pose e selecionar função são ações separadas.

- **VR de três pontos:** baixe/suba a cabeça para alternar em pé, agachado/cadeira, sentado no chão e deitado. Ajuste limiares se mudar cedo/tarde.
- **Desktop:** **C** agacha e **Z** deita. Se Z deixar sentado, aumente o limiar de deitar.
- **Costas/bruços:** a direção do rosto escolhe a orientação. Com ambas pode saltar para alternar. Desative em **Funções > Funções práticas** sem custos sincronizados adicionais.
- **Bloqueios:** fixe cabeça, braços e pés quando necessário. Sem gestos utiliza as mãos da pose em vez dos controladores.
- **Espelhar:** inverta a pose para olhar um amigo ou ajustar composição.

### Altura pés e Altura chão

**Altura pés** ajusta os pés mantendo a cabeça. Use quando flutuam ou afundam mas a cabeça já está correta.

**Altura chão** move todo o corpo e cabeça. Serve para sofá, cama e superfícies elevadas, mesmo sem collider. No controle centrado atual, **50% é a altura original**, 0% é 3 m abaixo e 100% 3 m acima. Volte perto de 50% para terminar. Versões antigas podem diferir; confirme a instalada e atualize sistema e produto juntos.

### Modo foto

Ative **Modo foto** no Unity antes de enviar. Em VRChat escolha pose, avance até 3 m com **Distância** e gire com **Direção**. Fixar pés é opcional ao compor. **Sair da foto** restaura distância/rotação e libera os pés.

Modo foto é local inicialmente. Ative **Sincronizar Modo foto** antes de enviar para mostrar posição/rotação a outros: utiliza 16 bits sincronizados. **Manter cabeça visível no Modo foto** só afeta a sua vista e não acrescenta bits.

### Respiração e Virar

Configure respiração por categoria em **Funções > Funções práticas > Animar respiração**. Escolha Nenhum, Fraco, Médio, Forte, Rápido ou animação própria. Movimento só sem bits; interruptor de menu 1 bit.

Virar exige pose deitada compatível e entrada **Virar**. Ative na pose e atribua animação lateral se necessário. Em VRChat escolha a pose, ative Virar e desbloqueie cabeça/pescoço. Inclinação lateral controla a rotação. MotionTime normal fica indisponível nessa pose.

As três poses de costas indicadas incluem movimentos laterais. Outras exigem animação e opções adequadas. Predefinições importadas/próprias podem ter atribuições diferentes.

## 5. Editar, adicionar e pré-visualizar

Em **Poses**, escolha categoria ou pesquisa. Aceita nomes japoneses originais e traduções disponíveis. **Detalhes** edita animação, ícone, ordem e tempo.

Arraste vários clips para a área ou selecione-os no Project e importe os selecionados. Referências duplicadas são removidas. Altere a posição nos Detalhes ou botões cima/baixo.

**Prévia** mostra na Scene sem abrir a janela completa. Não executa MA/NDMF: confirme roupa, correção do chão e outras funções no avatar compilado final.

Ícones do avatar identificam poses, mas demoram e podem aumentar dados. Reduza resolução para poupar. Android não gera ícones. Refaça após mudar avatar/roupa se necessário.

## 6. Memória de parâmetros

O Inspector mostra a parte das ferramentas, não o avatar inteiro. Roupa e outros sistemas podem gastar mais. Opções comuns não se contam duas vezes. Muitas poses adicionais podem exigir mais bits de seleção.

| Função | Bits sincronizados adicionais |
| --- | ---: |
| Seleção de poses mínima padrão | 8 |
| Espelhar | 1 |
| Sem gestos | 1 |
| Movimento da respiração | 0 |
| Interruptor da respiração | 1 |
| Altura pés | 8 |
| Altura chão | 8 |
| Modo foto local | 0 |
| Sincronizar Modo foto | 16 |
| Manter cabeça visível no Modo foto | 0 |
| Desativar balanço em repouso do VRChat | 0 |
| Virar | 10 |

Virar compartilha 1 bit com a correção de postura pela direção do pescoço: ambas continuam a utilizar 10 bits. O consumo indicado na versão instalada é a referência prática da configuração.

## 7. Atualizar e pré-calcular

1. Faça cópia do projeto e salve a cena.
2. Atualize **Kawaii Posing** e **Unisaki Posing System** juntos em VCC ou ALCOM, mantendo SDK/Modular Avatar/NDMF compatíveis.
3. Aguarde compilação, selecione a ferramenta instalada e reveja poses/opções/consumo.
4. Se usa pré-cálculo, pressione **Atualizar pré-cálculo** e envie novamente.

As configurações existentes são mantidas. Prefabs 8-bit antigos continuam por compatibilidade, sem eliminar/substituir ferramentas referenciadas. Novas instalações utilizam o normal; desative funções não usadas para poupar parâmetros.

Aviso de pré-cálculo desatualizado significa alterações desde a cache. Atualizar regenera os dados. Ocultar não atualiza nem resolve a origem. A compilação normal pode gerar o necessário sem pré-cálculo manual cada vez.

## 8. Resolução de problemas

| Sintoma | Verificar |
| --- | --- |
| Menu de adição ausente | Instale produto **e** sistema comum e resolva erros de compilação Console. O instalador da licença não é a biblioteca. |
| Instalador cancelado/arquivos removidos | Reimporte o instalador comprado e leia as confirmações. |
| Licença ausente em outro projeto | Importe com o mesmo usuário. Num novo computador/conta instale a licença. Idiomas não se transferem automaticamente. |
| Sem poses no VRChat | Adicione ao avatar certo da cena, ative poses, veja avisos e envie esse avatar. Verifique SDK e outras ferramentas de locomoção. |
| Z não deita | Aumente o limiar de altura para deitar. |
| Mãos/joelhos desalinhados | Experimente predefinição certa, IK compatível ou Ajuste de animação. Verifique roupa na compilação final. |
| Virar não funciona | Use pose compatível, ative opção e menu e desbloqueie cabeça/pescoço. Teste primeiro uma das três poses padrão compatíveis. |
| Amigos não veem movimento foto | Ative **Sincronizar Modo foto**, verifique consumo e envie novamente. |
| Idioma muda só no Unity | Envie novamente e verifique o seletor único superior nas versões localizadas. |
| Erros de compilação/pré-cálculo | Leia o **primeiro** erro relevante. Salve cópia, atualize ou obtenha de novo produto/sistema em VCC/ALCOM e contate assistência se persistir. Mantenha objetos ajustados e GeneratedResources salvo instrução específica. |

Para suporte indique versões produto/sistema, Unity/SDK/Modular Avatar/NDMF, avatar, passos exatos e erro Console. Retire arquivos privados, conteúdo do instalador, licenças e dados de conta de publicações.

- [Assistência](https://help.unisakistudio.jp/)
- [Manual ilustrado online (japonês)](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Página Gumroad](https://unisakistudio.gumroad.com/l/kawaii-posing)

## Licenças e créditos

É fornecida uma [tradução inglesa de referência do acordo do produto](../../Terms.en.html) junto ao original japonês.

Leia os acordos originais de produto/sistema junto ao README ou em `Licenses` no ZIP comprado. O inglês do sistema comum é uma tradução de referência existente; o acordo japonês do produto fica separado. O manual não altera acordos nem concede direitos adicionais. Consulte assistência sobre utilização/redistribuição.

O instalador inclui **VPMPackageAutoInstaller** modificado de **anatawa12**, com **SimpleJson** e **semver.net**. Direitos autorais e textos MIT estão em `ThirdPartyNotices.txt` no ZIP. Biblioteca e recursos têm licenças próprias.
