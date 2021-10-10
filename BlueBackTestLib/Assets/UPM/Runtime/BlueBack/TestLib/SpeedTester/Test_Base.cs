

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** Test_Base
	*/
	public interface Test_Base
	{
		/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測直前に呼び出される。
		*/
		void OnPreTestAction();

		/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測処理。
		*/
		void OnTestAction();

		/** [BlueBack.TestLib.SpeedTester.Test_Base.PreTest]計測終了直後に呼び出される。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		string OnTestResult(float a_delta_time);
	}
}

