

/** BlueBack.TestLib.Samples.SpeedTester_Interface
*/
namespace BlueBack.TestLib.Samples.SpeedTester_Interface
{
	/** Test_Interface
	*/
	public class Test_Interface : BlueBack.TestLib.SpeedTester.Test_Base
	{
		/** action
		*/
		public Action_Base action;

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
			this.action = new Action();
			this.result = 0;
		}

		/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測処理。
		*/
		public void OnTestAction()
		{
			for(int ii=0;ii<Config.MAX;ii++){
				this.action.Do(ref this.result);
			}
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

