# BlueBack.TestLib
テスト用ライブラリ
* 速度計測と「UI.Text」での表示。

## ライセンス
MIT License
* https://github.com/bluebackblue/TestLib/blob/main/LICENSE

## 動作確認
Unity 2020.2.4f1

## バージョン
### 最新
* https://github.com/bluebackblue/TestLib.git?path=unity_TestLib/Assets/UPM#0.0.7
### 開発
* https://github.com/bluebackblue/TestLib.git?path=unity_TestLib/Assets/UPM

## Unityへの追加方法
* Unity起動
* メニュー選択：「Window->Package Manager」
* ボタン選択：「左上の＋ボタン」
* リスト選択：Add package from git URL...
* アドレスを追加「 https://github.com/bluebackblue/TestLib.git?path=unity_TestLib/Assets/UPM#0.0.7 」
### 注
Gitクライアントがインストールされている必要がある。
* https://docs.unity3d.com/ja/current/Manual/upm-git.html
* https://git-scm.com/

## SpeedTester
速度計測と「UI.Text」での表示。

### サンプル

floatとintでの処理負荷を比較するサンプル。

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

「OnTestAction」内でリストから取得したfloatを足し続ける。
```
/** Test_Float
*/
public class Test_Float : BlueBack.TestLib.SpeedTester.ITest
{
	/** list
	*/
	private float[] list;

	/** result
	*/
	private float result;

	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測直前に呼び出される。
	*/
	public void OnPreTestAction()
	{
		//list
		this.list = new float[Config.MAX];
		for(int ii=0;ii<this.list.Length;ii++){
			this.list[ii] = ii;
		}

		//result
		this.result = 0.0f;
	}

	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測処理。
	*/
	public void OnTestAction()
	{
		float t_total = 0.0f;
		for(int ii=0;ii<this.list.Length;ii++){
			t_total += this.list[ii];
		}
		this.result = t_total;
	}

	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測終了直後に呼び出される。

		a_delta_time		: 処理秒数。
		return			: 表示文字列。

	*/
	public string OnTestResult(float a_delta_time)
	{
		return "Test_Float : " + a_delta_time.ToString("0.000") + " : result = " + this.result.ToString("0.0");
	}
}
```

「OnTestAction」内でリストから取得したintを足し続ける。
```
/** Test_Int
*/
public class Test_Int : BlueBack.TestLib.SpeedTester.ITest
{
	/** list
	*/
	private int[] list;

	/** result
	*/
	private int result;

	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測直前に呼び出される。
	*/
	public void OnPreTestAction()
	{
		//list
		this.list = new int[Config.MAX];
		for(int ii=0;ii<this.list.Length;ii++){
			this.list[ii] = ii;
		}

		//result
		this.result = 0;
	}

	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測処理。
	*/
	public void OnTestAction()
	{
		int t_total = 0;
		for(int ii=0;ii<this.list.Length;ii++){
			t_total += this.list[ii];
		}
		this.result = t_total;
	}

	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測終了直後に呼び出される。

		a_delta_time		: 処理秒数。
		return			: 表示文字列。

	*/
	public string OnTestResult(float a_delta_time)
	{
		return "Test_Int : " + a_delta_time.ToString("0.000") + " : result = " + this.result.ToString();
	}
}
```

![Sample01](/sample00.png)

