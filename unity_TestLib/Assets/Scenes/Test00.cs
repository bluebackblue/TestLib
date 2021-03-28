

/** Scenes
*/
namespace Scenes
{
	/** Test00
	*/
	public class Test00 : BlueBack.TestLib.SpeedTester.ITest
	{
		/** 計算結果。
		*/
		private float result;

		/** [BlueBack.TestLib.SpeedTester.PreTest]前処理。
		*/
		public void PreAction()
		{
			this.result = 0.0f;
		}

		/** [BlueBack.TestLib.SpeedTester.PreTest]計測するテスト処理。
		*/
		public void TestAction()
		{
			float t_result = 0.0f;

			for(int ii=0;ii<100;ii++){
				for(int jj=0;jj<100;jj++){
					for(int kk=0;kk<100;kk++){
						t_result += 1.0f;
					}
				}
			}

			this.result = t_result;
		}

		/** [BlueBack.TestLib.SpeedTester.PreTest]結果。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		public string Result(float a_delta_time)
		{
			return a_delta_time.ToString("0.000") + ":" + this.result.ToString();
		}
	}
}

