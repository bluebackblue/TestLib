

/** BlueBack.TestLib
*/
namespace BlueBack.TestLib
{
	/** Test_Base
	*/
	public interface Test_Base
	{
		/** [SpeedTest.Action_Base]テスト前処理。
		*/
		public void PreTest();

		/** [SpeedTest.Action_Base]テスト処理。
		*/
		public void Test();

		/** [SpeedTest.Action_Base]テスト結果。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		public string Result(float a_delta_time);
	}
}

