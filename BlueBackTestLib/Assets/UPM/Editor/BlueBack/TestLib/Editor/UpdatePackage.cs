

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief パッケージ更新。自動生成。
*/


/** BlueBack.TestLib.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.TestLib.Editor
{
	/** UpdatePackage
	*/
	public static class UpdatePackage
	{
		/** packageversion
		*/
		public const string packageversion = Version.packageversion;

		/** MenuItem_UpdatePackage_Develop
		*/
		#if(!DEF_USER_BLUEBACK_TESTLIB)
		[UnityEditor.MenuItem("BlueBack/TestLib/UpdatePackage/Develop")]
		#endif
		public static void MenuItem_UpdatePackage_Develop()
		{
			UnityEditor.PackageManager.Client.Add("https://github.com/bluebackblue/UpmTestLib.git?path=BlueBackTestLib/Assets/UPM");
		}

		/** MenuItem_UpdatePackage_Last
		*/
		#if(!DEF_USER_BLUEBACK_TESTLIB)
		[UnityEditor.MenuItem("BlueBack/TestLib/UpdatePackage/Last " + Version.packageversion)]
		#endif
		public static void MenuItem_UpdatePackage_Last()
		{
			string t_version = GetLastReleaseNameFromGitHub();
			if(t_version != null){
				UnityEditor.PackageManager.Client.Add("https://github.com/bluebackblue/UpmTestLib.git?path=BlueBackTestLib/Assets/UPM#" + t_version);
			}
		}

		/** DownloadBinary
		*/
		private static byte[] DownloadBinary(string a_url)
		{
			try{
				using(UnityEngine.Networking.UnityWebRequest t_webrequest = ((System.Func<UnityEngine.Networking.UnityWebRequest>)(()=>{
					return UnityEngine.Networking.UnityWebRequest.Get(a_url);
				}))()){
					UnityEngine.Networking.UnityWebRequestAsyncOperation t_async = t_webrequest.SendWebRequest();
					while(true){
						System.Threading.Thread.Sleep(1);
						if(t_async.isDone == true){
							if(t_webrequest.error != null){
								string t_text = "";
								if(t_webrequest.downloadHandler.text != null){
									t_text = t_webrequest.downloadHandler.text;
								}
								#if(UNITY_EDITOR)
								DebugTool.EditorLogError(a_url + " : " + t_webrequest.error + " : " + t_text);
								#endif
								return null;
							}else{
								return t_webrequest.downloadHandler.data;
							}
						}
					}
				}
			}catch(System.Exception t_exception){
				DebugTool.EditorLogError(a_url + " : " + t_exception.Message + "\n" + t_exception.StackTrace);
				return null;
			}
		}

		/** GetLastReleaseNameFromGitHub
		*/
		private static string GetLastReleaseNameFromGitHub()
		{
			string t_url = "https://api.github.com/repos/bluebackblue/UpmTestLib/releases/latest";

			try{
				byte[] t_binary = DownloadBinary(t_url);
				if(t_binary != null){
					string t_text = System.Text.Encoding.UTF8.GetString(t_binary,0,t_binary.Length);
					System.Text.RegularExpressions.Match t_match = System.Text.RegularExpressions.Regex.Match(t_text,".*(?<name>\\\"tag_name\\\")\\s*\\:\\s*\\\"(?<value>[a-zA-Z0-9_\\.]*)\\\".*");
					t_text = t_match.Groups["value"].Value;
					if(t_text != null){
						return t_text;
					}else{
						#if(UNITY_EDITOR)
						DebugTool.EditorLogError(t_url + " : text == null");
						#endif
						return null;
					}
				}else{
					#if(UNITY_EDITOR)
					DebugTool.EditorLogError(t_url + " : binary == null");
					#endif
					return null;
				}
			}catch(System.Exception t_exception){
				#if(UNITY_EDITOR)
				DebugTool.EditorLogError(t_url + " : " + t_exception.Message + "\n" + t_exception.StackTrace);
				#endif
				return null;
			}
		}
	}
}
#endif

