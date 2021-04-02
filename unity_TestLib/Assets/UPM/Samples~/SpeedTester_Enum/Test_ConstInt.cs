

/** Samples.TestLib.SpeedTester_Enum
*/
namespace Samples.TestLib.SpeedTester_Enum
{
	/** Test_ConstInt
	*/
	public class Test_ConstInt : BlueBack.TestLib.SpeedTester.ITest
	{
		/** ActionType
		*/
		private struct ActionType
		{
			public const int A = 0;
			public const int B = 1;
			public const int C = 2;
			public const int D = 3;
			public const int E = 4;
			public const int F = 5;
			public const int G = 6;
			public const int H = 7;
			public const int I = 8;
			public const int MAX = 9;
		}

		/** indexlist
		*/
		private int[] indexlist = new int[Config.MAX];
		
		/** result
		*/
		private int result;

		/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測直前に呼び出される。
		*/
		public void OnPreTestAction()
		{
			for(int ii=0;ii<this.indexlist.Length;ii++){
				this.indexlist[ii] = ii % ActionType.MAX;
			}

			this.result = 0;
		}

		/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測処理。
		*/
		public void OnTestAction()
		{
			for(int ii=0;ii<this.indexlist.Length;ii++){
				switch(this.indexlist[ii]){
				case ActionType.A:
					{
						this.result += 10;
					}break;
				case ActionType.B:
					{
						this.result += 11;
					}break;
				case ActionType.C:
					{
						this.result += 12;
					}break;
				case ActionType.D:
					{
						this.result += 13;
					}break;
				case ActionType.E:
					{
						this.result += 14;
					}break;
				case ActionType.F:
					{
						this.result += 15;
					}break;
				case ActionType.G:
					{
						this.result += 16;
					}break;
				case ActionType.H:
					{
						this.result += 17;
					}break;
				case ActionType.I:
					{
						this.result += 18;
					}break;
				}
			}
		}

		/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測終了直後に呼び出される。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		public string OnTestResult(float a_delta_time)
		{
			return this.GetType().Name + " : " + a_delta_time.ToString("0.000") + " : result = " + this.result.ToString();
		}
	}
}

