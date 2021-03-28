

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** SpeedTester
	*/
	public class SpeedTester
	{
		/**viewobject
		*/
		private ViewObject viewobject;

		/** test_list
		*/
		private ITest[] test_list;

		/** constructor

			a_test_list	: テストリスト。

		*/
		public SpeedTester(ITest[] a_test_list,Config a_config = null)
		{
			//config
			Config t_config = a_config;
			if(t_config == null){
				t_config = new Config();
			}

			//test_list
			this.test_list = a_test_list;

			//viewobject
			this.viewobject = new ViewObject(t_config,a_test_list.Length);
		}

		/** 削除。
		*/
		public void Delete()
		{
			//viewobject
			if(this.viewobject != null){
				this.viewobject.Delete();
				this.viewobject = null;
			}

			//test_list
			this.test_list = null;
		}

		/** テスト。

			a_index		: テストリストのインデックス。
			a_loop		: ループ回数。

		*/
		public void Test(int a_index,int a_loop)
		{
			ITest t_test = this.test_list[a_index];
			t_test.OnPreTestAction();
			{
				float t_time = UnityEngine.Time.realtimeSinceStartup;
				{
					for(int ii=0;ii<a_loop;ii++){
						t_test.OnTestAction();
					}
				}
				float t_delta_time = UnityEngine.Time.realtimeSinceStartup - t_time;
				this.viewobject.text_list[a_index].text = t_test.OnTestResult(t_delta_time);
			}
		}

		/** ランダムにテスト。

			a_loop		: ループ回数。

		*/
		public void RandomTest(int a_loop)
		{
			if(this.test_list != null){
				if(this.test_list.Length > 0){
					this.Test(UnityEngine.Random.Range(0,this.test_list.Length),a_loop);
				}
			}
		}
	}
}

