

/** BlueBack.TestLib.Samples.FloatInt
*/
namespace BlueBack.TestLib.Samples.FloatInt
{
	/** Test_Float
	*/
	public sealed class Test_Float : BlueBack.TestLib.SpeedTest.Test_Base
	{
		/** list
		*/
		private float[] list;

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
		public Test_Float()
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
			//list
			this.list = new float[Config.LISTMAX];
			for(int ii=0;ii<this.list.Length;ii++){
				this.list[ii] = ii;
			}

			//result
			this.result = 0;
		}

		/** [BlueBack.TestLib.SpeedTest.Test_Base]メイン。
		*/
		public void TestMain()
		{
			float t_value = 0;
			for(long ii=0;ii<Config.MAX;ii++){
				for(long jj=0;jj<this.list.Length;jj++){
					t_value += this.list[jj];
				}
			}
			this.result = (long)t_value;
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

