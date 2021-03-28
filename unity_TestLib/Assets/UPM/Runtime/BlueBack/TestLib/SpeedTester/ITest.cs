

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** ITest
	*/
	public interface ITest
	{
		/** [BlueBack.TestLib.SpeedTester.PreTest]前処理。
		*/
		public void PreAction();

		/** [BlueBack.TestLib.SpeedTester.PreTest]計測するテスト処理。
		*/
		public void TestAction();

		/** [BlueBack.TestLib.SpeedTester.PreTest]結果。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		public string Result(float a_delta_time);
	}
}

