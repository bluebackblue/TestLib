

/** Scenes
*/
namespace Scenes
{
	/** Test00
	*/
	public class Test00 : TestLib.Test_Base
	{
		/** 計算結果。
		*/
		private float result;

		/** [SpeedTest.Action_Base]テスト前処理。
		*/
		public void PreTest()
		{
			this.result = 0.0f;
		}

		/** [SpeedTest.Action_Base]テスト処理。
		*/
		public void Test()
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

		/** [SpeedTest.Action_Base]テスト結果。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		public string Result(float a_delta_time)
		{
			return a_delta_time.ToString("0.000") + ":" + this.result.ToString();
		}
	}
}

