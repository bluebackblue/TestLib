# BlueBack.TestLib

テスト用ライブラリ

## ライセンス
MIT License
* https://github.com/bluebackblue/TestLib/blob/main/LICENSE

## 動作確認
Unity 2020.2.4f1

## URL
https://github.com/bluebackblue/TestLib.git?path=unity_TestLib/Assets/UPM

## Unityへの追加方法
Unity起動
メニュー選択：「Window->Package Manager」
ボタン選択：「左上の＋ボタン」
リスト選択：Add package from git URL...
アドレスを追加「https://github.com/bluebackblue/TestLib.git?path=unity_TestLib/Assets/UPM」

## サンプル

```
	/** FloatIntSpeetTest
	*/
	public class FloatIntSpeetTest : UnityEngine.MonoBehaviour
	{
		/** speedtester
		*/
		BlueBack.TestLib.SpeedTester.SpeedTester speedtester;

		/** Start
		*/
		private void Start()
		{
			this.speedtester = new BlueBack.TestLib.SpeedTester.SpeedTester(new BlueBack.TestLib.SpeedTester.ITest[]{
				new Test_Float(),
				new Test_Int(),
			});
		}

		/** Update
		*/
		private void Update()
		{
			this.speedtester.RandomTest(Config.LOOP);
		}
	}
```

