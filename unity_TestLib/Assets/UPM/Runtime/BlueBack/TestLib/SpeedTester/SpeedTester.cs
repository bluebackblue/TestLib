

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

		*/
		public void Test(int a_index)
		{
			ITest t_test = this.test_list[a_index];

			//前処理。
			t_test.PreAction();

			//計測開始。
			float t_time = UnityEngine.Time.realtimeSinceStartup;
			
			//計測処理。
			{
				t_test.TestAction();
			}

			//計測終了。
			float t_delta_time = UnityEngine.Time.realtimeSinceStartup - t_time;

			//結果。
			this.viewobject.text_list[a_index].text = t_test.Result(t_delta_time);
		}

		/** ランダムにテスト。
		*/
		public void RandomTest()
		{
			if(this.test_list != null){
				if(this.test_list.Length > 0){
					this.Test(UnityEngine.Random.Range(0,this.test_list.Length));
				}
			}
		}
	}
}

