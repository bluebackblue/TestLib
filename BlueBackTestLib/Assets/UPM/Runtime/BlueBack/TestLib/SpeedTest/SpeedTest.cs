

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 速度テスト。
*/


/** BlueBack.TestLib.SpeedTest
*/
namespace BlueBack.TestLib.SpeedTest
{
	/** SpeedTest
	*/
	public sealed class SpeedTest : System.IDisposable
	{
		/** view
		*/
		private View view;

		/** list
		*/
		private Test_Base[] list;

		/** constructor

			a_test_list	: テストリスト。

		*/
		public SpeedTest(in InitParam a_initparam,Test_Base[] a_test_list)
		{
			//list
			this.list = a_test_list;

			//view
			this.view = new View(in a_initparam,a_test_list.Length);
		}

		/** [System.IDisposable]破棄。
		*/
		public void Dispose()
		{
			//view
			if(this.view != null){
				this.view.Dispose();
				this.view = null;
			}

			//list
			this.list = null;
		}

		/** テスト。

			a_index		: テストリストのインデックス。
			a_loop		: ループ回数。

		*/
		public void Test(int a_index,int a_loop)
		{
			Test_Base t_test = this.list[a_index];
			t_test.TestStart();
			{
				float t_time = UnityEngine.Time.realtimeSinceStartup;
				{
					for(int ii=0;ii<a_loop;ii++){
						t_test.TestMain();
					}
				}
				float t_delta_time = UnityEngine.Time.realtimeSinceStartup - t_time;
				this.view.text_list[a_index].text = t_test.TestEnd(t_delta_time);
			}
		}

		/** ランダムにテスト。

			a_loop		: ループ回数。

		*/
		public void RandomTest(int a_loop)
		{
			if(this.list != null){
				if(this.list.Length > 0){
					int t_index = UnityEngine.Random.Range(0,this.list.Length);
					this.Test(t_index,a_loop);
				}
			}
		}
	}
}

