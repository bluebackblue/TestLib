

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 速度テスト。
*/


/** BlueBack.TestLib.SpeedTest
*/
namespace BlueBack.TestLib.SpeedTest
{
	/** Test_Base
	*/
	public interface Test_Base
	{
		/** [BlueBack.TestLib.SpeedTest.Test_Base]直前に呼び出される。
		*/
		void TestStart();

		/** [BlueBack.TestLib.SpeedTest.Test_Base]メイン。
		*/
		void TestMain();

		/** [BlueBack.TestLib.SpeedTest.Test_Base]直後に呼び出される。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		string TestEnd(float a_delta_time);
	}
}

