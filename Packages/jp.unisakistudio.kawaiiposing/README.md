# 可愛いポーズツール
Version 2.2.5

# 概要
三点トラッキングでも可愛い姿勢で座ったり寝たりしたい！！
デスクトップでもフルトラみたいな生き生きとしたポーズで写真に写りたい！！
そんな方におすすめの簡単ポーズ固定ツールです。
ツールの導入は、超簡単！！ModularAvatar対応なのでPrefabsポン置きだけ！！
Expressionメニューで即座に切り替え可能！
VR睡眠したい人や集合写真の前列で中腰になりたいときにもお勧めです！
足の高さ変更機能で、コライダーのないベッドでも自由に寝られます！

# このツールでできること
- 現実で椅子や床に座っているときに可愛いｏｒカッコいい姿勢で座れます
- ＶＲ睡眠用の寝格好もあります！
- 姿勢は立ち用１５種、椅子用２０種、床用１７種、うつぶせ寝用１６種、あおむけ寝１７用
- うつぶせ、あおむけはジャンプで素早く切り替え可能
- メニューの画像は自動生成式！
- 別商品など好きなアニメーションを自由に設定可能！
- 既にオリジナルの「Stand」「Crouching」「Prone」姿勢がアバターに設定されている場合、自動で取り込む機能もあり！
- 「可愛い座りツール」「三点だいしゅきツール」「添い寝ツール」との互換性あり！
- 顔の向きでアニメーションが変にならないように頭のトラッキングを無効にする機能付き
- 姿勢の細かな調整のために足を床に固定する機能付き
- 頭・足・腕すべてを固定すると、SpaceDragなどで自分のアバターを第三者視点で見て、撮影などを楽しめます

# 注意事項
- フルボディトラッキング（フルトラ）の際は使用できません
- ExpressionParametersのメモリーを17bit使用します（足の高さ・左右反転機能を抜いた8bit版もあります）
- より快適に使用するためにはOVR Advanced Settingsなど、SpaceDrag機能のあるツールを併用することをお勧めいたします
- アニメーションはポンデロニウム研究所様の「桔梗」ちゃんをベースに作成しているため、手足や身長の違うアバターでは想定の姿勢にならないことがあります
- すでに「PlayableLayersの中のBaseLayerのBase」を使用している場合、自動で結合しますが、特殊な機能を使用している場合はうまくいかないことがあります
- 動作確認は「ModularAvatar1.11.0」「Non-Destructive Modular Framework1.6.1」で行っています
- VRCFuryとの互換性があり併用できます。ModularAvatarと互換性のある「VRCFury1.1150.0」で動作確認を行っています
- このツールはWindows向けです。LinuxやMacosのUnityでは使用できません

# この商品に含まれているファイル
- 立っている時用アニメーションファイル１５種
- 椅子に座っている時用アニメーションファイル２０種
- 床に座っている時用アニメーションファイル１７種
- 床に頭を付けている時用アニメーションファイル３３種（うつ伏せ寝１６種、あおむけ寝用１７種）
- VRChatアバターに設定するBaseLayer用AnimatorContorllerファイルとBrendTreeファイル
- 上記データを簡単に設定するためのModularAvatar対応Prefabs
- ゆにさきスタジオの別のツールや他ショップの商品を併用するための「他商品連携用Prefabs」

# 使い方
- 同封の「１．可愛いポーズツールライセンスのインストール」を起動し、処理が終了したらキーを押して閉じる
- 同封のショートカットより「ModularAvatar」と「可愛いポーズツール」をVCCに追加する
- VCCにて可愛いポーズツールをプロジェクトに追加する
- 事前にModularAvatarを導入してください
- 導入したいアバターを右クリックしてメニューから「ゆにさきスタジオ」の中にある「可愛いポーズツール追加」を選択
- そのまま通常通りアバターをアップロード
- ゲーム内のExpressionsメニュー（メニューボタン長押し）で、中腰時と座り時とうつ伏せ時と仰向け時の姿勢をそれぞれ一つずつ選択
- 頭の高さによって中腰、座り、寝格好が自動で切り替わります
- デスクトップモードの場合はｃキーとｚキーで姿勢が変わります
- デスクトップモードで寝姿勢を使用する場合はｚを押した後、設定の「寝の高さ閾値」を３５％以上に変更してください
- 下を向きながら頭を低くするとうつ伏せ、上を向きながら頭を低くするとあおむけになります
- ジャンプすると仰向けとうつ伏せが切り替わります
- 不要な姿勢があれば「可愛いポーズ」のインスペクターから無効化や削除ができます
- 設定メニューから各姿勢に切り替わる頭の高さの閾値を変更できます
- 「可愛い座りツール」「三点だいしゅきツール」「添い寝ツール」を導入済みのアバターの場合そのままでは使用できないので、ツールの設定をアバターからを削除する機能があります。
　また「他商品連携用Prefabs」のPrefabsを使用することで可愛いポーズツールと他ツールを併用することができます
- 「ジェスチャー無効」をオンにするとコントローラーによる手の形ではなく姿勢にあった手の形が使われるようになります

# 利用規約
このツールはVN3ライセンスで作成された以下の利用規約に同意された方のみご利用いただけます。
https://drive.google.com/file/d/1LN2gW2eokOAUarazWuXySI4LFcoINX5S/view?usp=sharing

# 連携設定同封商品
※連携設定は一方的に弊ショップが作成しているもので、該当商品の作者からの許可は不要と考えて取っていません。
連携設定の配布の希望や配布停止の申し出についてはショップのメッセージからお願いします。
連携設定は連携する商品の購入・ダウンロードが必要です。
設定に関して問題が生じた場合には各商品の作者ではなく弊ショップへご連絡ください。

『可愛い座りツール』
https://yunisaki.booth.pm/items/3611536

『添い寝ツール』
https://yunisaki.booth.pm/items/3670993

『少女モーション集vol.1』 by ゆにみのアトリエ
https://unimirai.booth.pm/items/3512020

『VRC想定移動モーション（無料配布）』 by カトのVRC道具屋
https://booth.pm/ja/items/1285101

『ごろ寝システムEX』 by minminmart
https://minminmart.booth.pm/items/4233545


# For English speakers
Please read description and how to use this tool with translate.

Please read terms of use before buy or use this tool and assets.
Terms of use
https://drive.google.com/file/d/1B0O7Eofp4d5vViMRJ1UYPG2UC110eVGi/view?usp=sharing
