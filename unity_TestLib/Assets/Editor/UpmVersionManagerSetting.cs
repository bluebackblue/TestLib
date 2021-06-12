

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 設定。
*/


/** Editor
*/
#if(UNITY_EDITOR)
namespace Editor
{
	/** UpmVersionManagerSetting
	*/
	[UnityEditor.InitializeOnLoad]
	public static class UpmVersionManagerSetting
	{
		/** UpmVersionManagerSetting
		*/
		static UpmVersionManagerSetting()
		{
			//Object_RootUssUxml
			BlueBack.UpmVersionManager.Editor.Object_RootUssUxml.CreateFile(false);

			BlueBack.UpmVersionManager.Editor.Object_Setting.CreateInstance();
			BlueBack.UpmVersionManager.Editor.Object_Setting.Param t_param = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param();
			{
				//author_name
				t_param.author_name = "BlueBack";

				//author_url
				t_param.author_url = "https://github.com/bluebackblue";

				//■package_name
				t_param.package_name = "TestLib";

				//■getpackageversion
				t_param.getpackageversion = BlueBack.TestLib.Version.GetPackageVersion;

				//packagejson_unity
				t_param.packagejson_unity = "2020.1";

				//■packagejson_discription
				t_param.packagejson_discription = "テスト用ライブラリ";

				//■packagejson_keyword
				t_param.packagejson_keyword = new string[]{
					"test"
				};

				//■changelog
				t_param.changelog = new string[]{
					"# Changelog",
					"",

					/*
					"## [0.0.0] - 0000-00-00",
					"### Changes",
					"- Init",
					"",
					*/

					"## [0.0.1] - 2021-03-27",
					"### Changes",
					"- Init",
					"",
				};

				//■readme_md
				t_param.object_root_readme_md = new BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Type[]{

					//概要。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"# " + a_argument.param.author_name + "." + a_argument.param.package_name,
							"テスト用ライブラリ",
							"* 速度計測と計測結果の画面表示",
						};
					},

					//ライセンス。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## ライセンス",
							"MIT License",
							"* " + a_argument.param.author_url + "/" + a_argument.param.package_name + "/blob/main/LICENSE",
						};
					},

					//依存。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 外部依存 / 使用ライセンス等",
							//"* " + a_argument.param.author_url + "/" + "AssetLib",
							//"### サンプルのみ",
							//"* " + a_argument.param.author_url + "/" + "AssetLib",
						};
					},

					//動作確認。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 動作確認",
							"Unity " + UnityEngine.Application.unityVersion,
						};
					},

					//UPM。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## UPM",
							"### 最新",
							"* " + a_argument.param.author_url + "/" + a_argument.param.package_name + ".git?path=unity_" + a_argument.param.package_name + "/Assets/UPM#" + a_argument.version,
							"### 開発",
							"* " + a_argument.param.author_url + "/" + a_argument.param.package_name + ".git?path=unity_" + a_argument.param.package_name + "/Assets/UPM",
						};
					},

					//インストール。 
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## Unityへの追加方法",
							"* Unity起動",
							"* メニュー選択：「Window->Package Manager」",
							"* ボタン選択：「左上の＋ボタン」",
							"* リスト選択：「Add package from git URL...」",
							"* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」",
							"### 注",
							"Gitクライアントがインストールされている必要がある。",
							"* https://docs.unity3d.com/ja/current/Manual/upm-git.html",
							"* https://git-scm.com/",
						};
					},

					//例。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 例",


							"floatとintでの処理負荷を比較するサンプル。",


							"```",
							"/** FloatIntSpeetTest",
							"*/",
							"public class FloatIntSpeetTest : UnityEngine.MonoBehaviour",
							"{",
							"	/** speedtester",
							"	*/",
							"	BlueBack.TestLib.SpeedTester.SpeedTester speedtester;",
							"",
							"	/** Start",
							"	*/",
							"	private void Start()",
							"	{",
							"		this.speedtester = new BlueBack.TestLib.SpeedTester.SpeedTester(new BlueBack.TestLib.SpeedTester.ITest[]{",
							"			new Test_Float(),",
							"			new Test_Int(),",
							"		});",
							"	}",
							"",
							"	/** Update",
							"	*/",
							"	private void Update()",
							"	{",
							"		this.speedtester.RandomTest(Config.LOOP);",
							"	}",
							"}",

							"```",


							"「OnTestAction」内でリストから取得したfloatを足し続ける。",


							"```",
							"/** Test_Float",
							"*/",
							"public class Test_Float : BlueBack.TestLib.SpeedTester.ITest",
							"{",
							"	/** list",
							"	*/",
							"	private float[] list;",
							"",
							"	/** result",
							"	*/",
							"	private float result;",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測直前に呼び出される。",
							"	*/",
							"	public void OnPreTestAction()",
							"	{",
							"		//list",
							"		this.list = new float[Config.MAX];",
							"		for(int ii=0;ii<this.list.Length;ii++){",
							"			this.list[ii] = ii;",
							"		}",
							"",
							"		//result",
							"		this.result = 0.0f;",
							"	}",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測処理。",
							"	*/",
							"	public void OnTestAction()",
							"	{",
							"		float t_total = 0.0f;",
							"		for(int ii=0;ii<this.list.Length;ii++){",
							"			t_total += this.list[ii];",
							"		}",
							"		this.result = t_total;",
							"	}",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測終了直後に呼び出される。",
							"",
							"		a_delta_time	: 処理秒数。",
							"		return		: 表示文字列。",
							"",
							"	*/",
							"	public string OnTestResult(float a_delta_time)",
							"	{",
							"		return \"Test_Float : \" + a_delta_time.ToString(\"0.000\") + \" : result = \" + this.result.ToString(\"0.0\");",
							"	}",
							"}",
							"```",


							"「OnTestAction」内でリストから取得したintを足し続ける。",


							"```",
							"/** Test_Int",
							"*/",
							"public class Test_Int : BlueBack.TestLib.SpeedTester.ITest",
							"{",
							"	/** list",
							"	*/",
							"	private int[] list;",
							"",
							"	/** result",
							"	*/",
							"	private int result;",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測直前に呼び出される。",
							"	*/",
							"	public void OnPreTestAction()",
							"	{",
							"		//list",
							"		this.list = new int[Config.MAX];",
							"		for(int ii=0;ii<this.list.Length;ii++){",
							"			this.list[ii] = ii;",
							"		}",
							"",
							"		//result",
							"		this.result = 0;",
							"	}",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測処理。",
							"	*/",
							"	public void OnTestAction()",
							"	{",
							"		int t_total = 0;",
							"		for(int ii=0;ii<this.list.Length;ii++){",
							"			t_total += this.list[ii];",
							"		}",
							"		this.result = t_total;",
							"	}",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測終了直後に呼び出される。",
							"",
							"		a_delta_time	: 処理秒数。",
							"		return		: 表示文字列。",
							"",
							"	*/",
							"	public string OnTestResult(float a_delta_time)",
							"	{",
							"		return \"Test_Int : \" + a_delta_time.ToString(\"0.000\") + \" : result = \" + this.result.ToString();",
							"	}",
							"}",
							"```",


							"![Sample01](/sample00.png)",

						};
					},

				};
			}

			BlueBack.UpmVersionManager.Editor.Object_Setting.GetInstance().Set(t_param);
		}
	}
}
#endif

