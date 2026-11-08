# Kawaii Posing

Ferramenta de poses VRChat para poses sentadas e deitadas adoráveis, com rastreamento de 3 pontos ou desktop. Inclui 85 poses: 15 em pé, 20 agachadas, 17 sentadas, 16 de bruços e 17 de costas.

Este README refere-se a v3.2.0 em desenvolvimento. A data oficial não está definida. A versão instalada aparece no topo do Inspector.

- [Página na BOOTH](https://yunisaki.booth.pm/items/5479202)
- [Histórico](CHANGELOG.md)

## Idioma de apresentação e documentos offline

Escolha o idioma em «Language / 言語», no topo do Inspector. Uma única escolha aplica-se ao Inspector e aos menus VRChat gerados. Carregue novamente o avatar para mudar o idioma dentro do jogo.

Sem escolha explícita, é usado o idioma do computador; idiomas não suportados utilizam inglês. São suportados Windows, macOS e Linux. A última escolha é guardada em EditorPrefs e reutilizada noutros projetos do mesmo utilizador do sistema neste computador. Uma escolha explícita já guardada no avatar é mantida. Não existe sincronização com outros computadores. O armazenamento da licença não é alterado.

Escolha o idioma do README, histórico e manual na [lista de idiomas](../index.html) incluída. Os atalhos do Inspector para manual e alterações seguem a seleção. Os termos originais e as traduções de referência continuam disponíveis em separado.

## Principais funções

- Modo foto: avance até 3m e mude direção. 0 bit local, 16 bit para mostrar posição/direção aos outros.
- Cabeça visível em fotos: impede ocultar a cabeça própria próxima apenas durante Modo foto.
- Altura chão: move corpo e cabeça 3m acima/abaixo. 50% original/inicial, 0% 3m abaixo, 100% 3m acima. Separado de Altura pés com cabeça fixa.
- Virar: inclinação da cabeça vira para os lados em poses compatíveis.
- Respiração: anima peito e outras partes; Nenhum, Fraco, Médio, Forte, Rápido ou Personalizado por categoria.
- Desativar balanço em repouso do VRChat: reduz balanço padrão mantendo respiração e movimentos próprios.
- Reduzir deformação por rotação da cabeça: limita deformação ao libertar pescoço numa direção diferente da original.
- Seleção de funções: acrescente só menus desejados e consulte ExpressionParameters.
- Pesquisa, importação múltipla e ordem: pesquisa transversal, vários clips e destino na lista.
- Pré-visualização na Scene: veja a pose diretamente na lista.

- Ajuste automático dos membros (IK): adapta posições às proporções nas poses compatíveis, com ativação por pose e integração em animação de ajuste.

### Virar com poses incluídas

Pernas esticadas, Relaxado e Um joelho levantado, de costas, já têm movimentos laterais. Para virar, baseiam-se respetivamente em «横向き寝» (de lado), Sesta e Sesta de gato.

Ative «Funções > Funções do menu > Virar», envie e escolha pose compatível e Virar em VRChat. Desbloqueie o pescoço.

Para configurar, ative «Poses > Detalhes > Ativar Virar» e atribua Pose lateral para virar. MotionTime normal deixa de estar disponível nessa pose.

### Ajuste às proporções

Pode utilizar a automação incluída, mas nem todas as poses precisam de IK. Ativar ajuste automático dos membros controla tudo; Ativar IK para esta pose controla individualmente.

Incorporar IK aos ajustes escreve o resultado atual numa nova animação e desativa IK na pose. Depois pode aperfeiçoar manualmente. Exige ajuste global e da pose ativos e regras aplicáveis.

Configuração do avatar também tem Impedir flexão inversa dos joelhos e o detalhe Flexão mínima do joelho (graus).

## Instalação

1. Transfira os ficheiros da página do produto na loja de compra.
2. Importe «可愛いポーズツール.unitypackage» no Unity e registe licença e origem dos pacotes.
3. Em VCC ou ALCOM adicione Kawaii Posing e Modular Avatar ao projeto. Unisaki Posing System e NDMF são dependências.
4. Clique com o botão direito no avatar da Hierarchy e escolha Unisaki Studio > Adicionar Kawaii Posing.
5. Selecione Kawaii Posing no avatar e configure funções e poses no Inspector.
6. Envie normalmente.

Requisitos: Unity 2022.3, VRChat Avatars SDK 3.10.4 ou posterior, Modular Avatar 1.x desde 1.15.1 e NDMF 1.x desde 1.14.0. Atualize os pacotes necessários em conjunto com VCC ou ALCOM.

## Atualizar versões anteriores

Atualize produto e Unisaki Posing System juntos. Configurações existentes são mantidas. Reveja funções e ExpressionParameters; se usava pré-cálculo, atualize-o antes de enviar novamente.

Desde v3.1.0, novas instalações usam o Prefab normal 「可愛いポーズ」. Sem funções desnecessárias, a seleção mínima utiliza 8 bit; muitas poses podem precisar de bits adicionais.

Prefabs 8bit antigos ficam em Editor/Legacy para preservar avatares e predefinições. Não é necessário eliminar ou substituir. O menu de adição já não mostra 8bit.

## Onde configurar

| Separador | Utilização |
| --- | --- |
| Funções | Menus, funções práticas, respiração, ícones e ExpressionParameters |
| Poses | Seleção, detalhes, pesquisa, importação múltipla, ordem, pré-visualização e ajuste |
| Configuração do avatar | Correções próprias e de joelhos, movimentos originais/próprios e predefinições |

Abra as definições para mostrar detalhes sob a opção. Respiração fica em Funções > Funções práticas > Animar respiração.

Usar poses originais em pé, agachado e de bruços importa automaticamente as posturas do avatar. Para movimentos próprios, abra importação separada e atribua por tipo: em pé, agachado (Crouching), de bruços (Prone), etc.

Predefinições estão no fim de Configuração do avatar. Aplicar esta predefinição substitui poses atuais; guarde os ajustes primeiro.

### Consumo por função

- Respiração sozinha 0 bit; menu para parar/reiniciar usa 1 bit sincronizado.
- Modo foto local 0 bit; Funções práticas > Sincronizar Modo foto usa 16 bit; cabeça visível 0 bit.
- Altura pés e Altura chão usam 8 bit cada. Afastar o chão do centro move verticalmente; voltar perto de 50% termina.
- Virar usa 10 bit, partilhando 1 bit com a correção da cabeça; ambas continuam com 10 bit.
- Espelhar e Sem gestos usam 1 bit cada.

O total do Inspector refere-se às ferramentas de poses, sem roupa ou outros sistemas. Funções comuns de várias ferramentas não se repetem no consumo.

### Pré-visualização e edição

Pré-visualização mostra a pose na Scene. Para corrigir detalhes abra Ajuste de animação, edite vendo o resultado e guarde.

A visualização simples não executa MA/NDMF. Verifique também o resultado da compilação antes de enviar, incluindo roupa e correção do chão.

A lupa pesquisa nomes. Ordene em Detalhes > Ordem ou nos botões cima/baixo. Importe vários clips arrastando ou com Importar clips selecionados em Project.

Atualizar miniaturas das poses gera imagens após confirmar. Gerar ícones das poses facilita a seleção mas demora mais na compilação. Reduzir tamanho dos ícones poupa espaço. Android não gera ícones.

## Controlos básicos no jogo

- Selecione poses por categoria em Expressions. Em VR a altura da cabeça alterna em pé, agachado, sentado e deitado.
- Direção do rosto decide costas/bruços. Com ambas escolhidas, pode saltar para alternar. Desative em Funções → Funções práticas → Trocar poses deitadas pulando, inicialmente ativo. Limiares do menu regulam as alturas.
- No desktop use C e Z; se Z não deitar, aumente o limiar de altura para deitar.
- Sem gestos utiliza mãos da pose em vez dos gestos dos controladores.
- Altura pés mantém a cabeça; Altura chão move o corpo todo. Aparecem nessa ordem.
- Distância no Modo foto avança e vira o avatar para si; Direção roda. Fixar pés é opcional no momento escolhido. Sair da foto repõe distância/direção e liberta pés.
- Respiração exige movimento ativo; intensidade no Unity e ativação no jogo.

## Pré-cálculo e avisos

Atualizar pré-cálculo reutiliza dados para acelerar compilação. Sem ele, a compilação normal gera o necessário.

Verificar configurações e símbolos Hierarchy avisam atualizações após alterações. Configurações de exibição dos avisos estão no mesmo painel. Ocultar não corrige nem regenera.

## Notas de utilização

- Fixação com rastreamento de corpo inteiro não suportada.
- Proporções, roupa e alterações podem requerer ajustes.
- Base especial ou outros sistemas podem falhar na integração. Verifique Configuração do avatar > Integrar bloqueios de rastreamento com outras ferramentas.
- Movimento/rotação do Modo foto e altura do chão também corrigem movimentos padrão/próprios sem pose. Verifique vista e substituições no cliente VRChat.
- Supressão do balanço padrão só afeta repouso normal, não todas as causas.

## Manual e assistência

Ajuda / Alterações no topo abre manual, assistência e histórico. Funções comuns também estão em Packages > Unisaki Posing System > README no Project.

- [Manual oficial](https://docs.unisakistudio.jp/kawaiiposing/manual/)
- [Assistência](https://help.unisakistudio.jp/)

Comunique versões do produto, sistema comum, Unity, VRChat SDK, Modular Avatar e NDMF, avatar utilizado, passos de reprodução e erros da Console.

## Distribuir predefinições

Informação sobre dados criados pelo ajuste de animação.

Pode distribuir e vender livremente ficheiros de animação de ajuste criados com esta função
e predefinições criadas com esses ficheiros atribuídos, sem autorização do Unisaki Studio.
Partilhe-os, por exemplo, com avatares próprios ou para avatares não incluídos na ferramenta.

## Produtos com integração incluída

As configurações de integração foram criadas unilateralmente pela nossa loja. Não solicitámos autorização aos autores, por considerarmos desnecessária.
Solicite distribuição ou interrupção por mensagem à loja.
A integração exige compra e transferência do produto correspondente.
Problemas nestas configurações devem ser dirigidos à nossa loja, não aos autores dos outros produtos.

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

## Termos de utilização

Só pode utilizar esta ferramenta quem aceitar os termos seguintes, criados com a licença VN3.

[Termos de utilização (japonês)](https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing)

O código-fonte e recursos não são de código aberto. Exigem compra legítima e aceitação dos termos.

[Termos de utilização (inglês)](https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing)
