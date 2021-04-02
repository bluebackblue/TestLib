

/** Samples.TestLib.SpeedTester_Enum
*/
namespace Samples.TestLib.SpeedTester_Enum
{
	/** Test_Enum
	*/
	public class Test_Enum : BlueBack.TestLib.SpeedTester.ITest
	{
		/** ActionType
		*/
		private enum ActionType
		{
			A = 0,
			B = 1,
			C = 2,
			D = 3,
			E = 4,
			F = 5,
			G = 6,
			H = 7,
			I = 8,
			MAX = 9,
		}

		/** indexlist
		*/
		private ActionType[] indexlist = new ActionType[Config.MAX];
		
		/** result
		*/
		private int result;

		/** [BlueBack.TestLib.SpeedTester.ITest.PreTest]計測直前に呼び出される。
		*/
		public void OnPreTestAction()
		{
			for(int ii=0;ii<this.indexlist.Length;ii++){
				this.indexlist[ii] = (ActionType)(ii % (int)ActionType.MAX);
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

