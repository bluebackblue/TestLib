

/** BlueBack.TestLib.Samples.EnumConstInt
*/
namespace BlueBack.TestLib.Samples.EnumConstInt
{
	/** Test_Enum
	*/
	public sealed class Test_Enum : BlueBack.TestLib.SpeedTest.Test_Base
	{
		/** ActionType
		*/
		private enum ActionType
		{
			AA = 0,
			AB,
			AC,
			AD,
			AE,
			AF,
			AG,
			AH,
			AI,
			AJ,

			BA,
			BB,
			BC,
			BD,
			BE,
			BF,
			BG,
			BH,
			BI,
			BJ,

			CA,
			CB,
			CC,
			CD,
			CE,
			CF,
			CG,
			CH,
			CI,
			CJ,

			DA,
			DB,
			DC,
			DD,
			DE,
			DF,
			DG,
			DH,
			DI,
			DJ,

			MAX,
		}

		/** indexlist
		*/
		private ActionType[] indexlist = new ActionType[(int)ActionType.MAX * 30];

		/** result
		*/
		private long result;

		/** count
		*/
		private int count;

		/** average
		*/
		private float average;

		/** constructor
		*/
		public Test_Enum()
		{
			//count
			this.count = 0;

			//average
			this.average = 0.0f;
		}

		/** [BlueBack.TestLib.SpeedTest.Test_Base]直前に呼び出される。
		*/
		public void TestStart()
		{
			//indexlist
			for(int ii=0;ii<this.indexlist.Length;ii++){
				this.indexlist[ii] = (ActionType)UnityEngine.Random.Range(0,(int)ActionType.MAX);
			}

			//result
			this.result = 0;
		}

		/** [BlueBack.TestLib.SpeedTest.Test_Base]メイン。
		*/
		public void TestMain()
		{
			for(long ii=0;ii<Config.MAX;ii++){
				for(long jj=0;jj<this.indexlist.Length;jj++){
					switch(this.indexlist[jj]){
					case ActionType.AA:
					case ActionType.BA:
					case ActionType.CA:
					case ActionType.DA:
						{
							this.result++;
						}break;
					case ActionType.AB:
					case ActionType.BB:
					case ActionType.CB:
					case ActionType.DB:
						{
							this.result++;
						}break;
					case ActionType.AC:
					case ActionType.BC:
					case ActionType.CC:
					case ActionType.DC:
						{
							this.result++;
						}break;
					case ActionType.AD:
					case ActionType.BD:
					case ActionType.CD:
					case ActionType.DD:
						{
							this.result++;
						}break;
					case ActionType.AE:
					case ActionType.BE:
					case ActionType.CE:
					case ActionType.DE:
						{
							this.result++;
						}break;
					case ActionType.AF:
					case ActionType.BF:
					case ActionType.CF:
					case ActionType.DF:
						{
							this.result++;
						}break;
					case ActionType.AG:
					case ActionType.BG:
					case ActionType.CG:
					case ActionType.DG:
						{
							this.result++;
						}break;
					case ActionType.AH:
					case ActionType.BH:
					case ActionType.CH:
					case ActionType.DH:
						{
							this.result++;
						}break;
					case ActionType.AI:
					case ActionType.BI:
					case ActionType.CI:
					case ActionType.DI:
						{
							this.result++;
						}break;
					case ActionType.AJ:
					case ActionType.BJ:
					case ActionType.CJ:
					case ActionType.DJ:
						{
							this.result++;
						}break;
					}
				}
			}
		}

		/** [BlueBack.TestLib.SpeedTest.Test_Base]直後に呼び出される。

			a_delta_time		: 処理秒数。
			return			: 表示文字列。

		*/
		public string TestEnd(float a_delta_time)
		{
			this.count++;
			if(this.average == 0.0f){
				this.average = a_delta_time;
			}
			this.average = UnityEngine.Mathf.Lerp(this.average,a_delta_time,0.01f);
			return string.Format("{0} : max = {1} : count = {2} : result = {3}\ndelta = {4}\naverage = {5}",
				this.GetType().Name,
				Config.MAX,
				this.count,
				this.result,
				string.Format("{0:0.000}",a_delta_time),
				string.Format("{0:0.000}",this.average)
			);
		}
	}
}

