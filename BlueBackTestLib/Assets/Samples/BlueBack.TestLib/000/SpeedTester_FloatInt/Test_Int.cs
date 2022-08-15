

/** BlueBack.TestLib.Samples.SpeedTester_FloatInt
*/
namespace BlueBack.TestLib.Samples.SpeedTester_FloatInt
{
	/** Test_Int
	*/
	public sealed class Test_Int : BlueBack.TestLib.SpeedTester.Test_Base
	{
		/** list
		*/
		private int[] list;

		/** result
		*/
		private int result;

		/** count
		*/
		private int count = 0;

		/** delta_time
		*/
		private float delta_time = 0.0f;

		/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測直前に呼び出される。
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

		/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測処理。
		*/
		public void OnTestAction()
		{
			int t_total = 0;
			for(int ii=0;ii<this.list.Length;ii++){
				t_total += this.list[ii];
			}
			this.result = t_total;
		}

		/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測終了直後に呼び出される。

			a_delta_time	: 処理秒数。
			return			: 表示文字列。

		*/
		public string OnTestResult(float a_delta_time)
		{
			this.count++;
			this.delta_time = UnityEngine.Mathf.Lerp(this.delta_time,a_delta_time,0.01f);
			return string.Format("{0} {1} {2} {3} result = {4}",
				this.GetType().Name,
				this.count,
				a_delta_time.ToString("0.000"),
				this.delta_time.ToString("0.000"),
				this.result
			);
		}
	}
}

