# 自作スイカゲーム

## [スイカゲームとは](https://store-jp.nintendo.com/list/software/70010000043363.html)

# 概要
動画配信サイトでスイカゲームのプレイ動画を拝見し、「自分で作成できるかも」と思って制作を始めたプロジェクトになります。

# 開発環境
Unity 2020.3.30f1

# 進捗
（202312月16時点未完成でまだ動作はしません）

| 本家 | 本プロジェクト |
| ---- | ---- |
| さくらんぼ | 種（seed） |
| イチゴ | 花（flower） |
| ぶどう | かぼちゃ |
| みかん | かぼちゃのタルト |
| 柿 | ライスコロッケ |
| リンゴ | イタリアの国旗 |
| 梨 | 地球 |
| 桃 | サル |
| メロン | ゴリラ |
| スイカ | バナナ |

上記のルールに基づいて、たとえばさくらんぼ同士がぶつかったらイチゴになるように、同種のオブジェクトが接触したときに、一つ上のランクのオブジェクトになるようなスクリプト(seed.cs,pumpkin.cs)を記述。
Seedオブジェクト同士が接触したときにpumpkinオブジェクトが一つ生成される動作をUnityエディタ上で確認。



