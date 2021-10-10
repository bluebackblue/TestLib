

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
			BlueBack.UpmVersionManager.Editor.Object_RootUssUxml.Save(false);

			BlueBack.UpmVersionManager.Editor.Object_Setting.s_param = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param();
			BlueBack.UpmVersionManager.Editor.Object_Setting.Param t_param = BlueBack.UpmVersionManager.Editor.Object_Setting.s_param;
			{
				//author_name
				t_param.author_name = "BlueBack";

				//git_url
				t_param.git_url = "https://github.com/";

				//git_author
				t_param.git_author = "bluebackblue";

				//git_path
				t_param.git_path = "BlueBackTestLib/Assets/UPM";

				//git_repos
				t_param.git_repos = "UpmTestLib";

				//package_name
				t_param.package_name = "TestLib";

				//packagejson_unity
				t_param.packagejson_unity = "2020.1";

				//packagejson_discription
				t_param.packagejson_discription = "テスト用ライブラリ";

				//packagejson_keyword
				t_param.packagejson_keyword = new string[]{
					"test",
				};

				//packagejson_dependencies
				t_param.packagejson_dependencies = new System.Collections.Generic.Dictionary<string,string>(){
					//{"xxxxx.xxxxx","https://github.com/xxxxx/xxxxx"},
				};

				//root_readmemd_path
				t_param.root_readmemd_path = "../../README.md";

				//asmdef_runtime
				t_param.asmdef_runtime = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//asmdef_editor
				t_param.asmdef_editor = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.TestLib",
							url = "https://github.com/bluebackblue/TestLib",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//asmdef_sample
				t_param.asmdef_sample = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.TestLib",
							url = "https://github.com/bluebackblue/TestLib",
						},
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.TestLib.Editor",
							url = "https://github.com/bluebackblue/TestLib",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//changelog
				t_param.changelog = new string[]{
					"# Changelog",
					"",

					"## [0.0.1] - 2021-10-06",
					"### Changes",
					"- Init",
					"",
				};

				//readme_md
				t_param.object_root_readme_md = new BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Type[]{

					//概要。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"# " + t_param.author_name + "." + t_param.package_name,
							"テスト用ライブラリ",
							"* 速度計測と計測結果の画面表示",
						};
					},

					//ライセンス。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## ライセンス",
							"MIT License",
							"* " + t_param.git_url + t_param.git_author + "/" + t_param.package_name + "/blob/main/LICENSE",
						};
					},

					//依存。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						System.Collections.Generic.List<string> t_list = new System.Collections.Generic.List<string>();
						t_list.Add("## 依存 / 使用ライセンス等");
						t_list.AddRange(BlueBack.UpmVersionManager.Editor.Object_Setting.Create_RootReadMd_Asmdef_Dependence(a_argument));
						return t_list.ToArray();
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
							"* " + t_param.git_url + t_param.git_author + "/" + t_param.git_repos + ".git?path=" + t_param.git_path + "#" + a_argument.version,
							"### 開発",
							"* " + t_param.git_url + t_param.git_author + "/" + t_param.git_repos + ".git?path=" + t_param.git_path,
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
							"		this.speedtester = new BlueBack.TestLib.SpeedTester.SpeedTester(new BlueBack.TestLib.SpeedTester.Test_Base[]{",
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
							"public class Test_Float : BlueBack.TestLib.SpeedTester.Test_Base",
							"{",
							"	/** list",
							"	*/",
							"	private float[] list;",
							"",
							"	/** result",
							"	*/",
							"	private float result;",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測直前に呼び出される。",
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
							"	/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測処理。",
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
							"	/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測終了直後に呼び出される。",
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
							"public class Test_Int : BlueBack.TestLib.SpeedTester.Test_Base",
							"{",
							"	/** list",
							"	*/",
							"	private int[] list;",
							"",
							"	/** result",
							"	*/",
							"	private int result;",
							"",
							"	/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測直前に呼び出される。",
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
							"	/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測処理。",
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
							"	/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測終了直後に呼び出される。",
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
		}
	}
}
#endif

