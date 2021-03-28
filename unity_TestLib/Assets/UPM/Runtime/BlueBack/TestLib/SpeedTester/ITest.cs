

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** ITest
	*/
	public interface ITest
	{
		/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測直前に呼び出される。
		*/
		public void OnPreTestAction();

		/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測処理。
		*/
		public void OnTestAction();

		/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測終了直後に呼び出される。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		public string OnTestResult(float a_delta_time);
	}
}

