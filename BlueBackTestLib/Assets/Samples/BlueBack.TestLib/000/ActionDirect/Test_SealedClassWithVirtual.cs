

/** BlueBack.TestLib.Samples.ActionDirect
*/
namespace BlueBack.TestLib.Samples.ActionDirect
{
	/** Test_SealedClassWithVirtual
	*/
	public sealed class Test_SealedClassWithVirtual : BlueBack.TestLib.SpeedTest.Test_Base
	{
		/** action
		*/
		public Action_SealedClassWithVirtual action;

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
		public Test_SealedClassWithVirtual()
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
			//action
			this.action = new Action_SealedClassWithVirtual();

			//result
			this.result = 0;
		}

		/** [BlueBack.TestLib.SpeedTest.Test_Base]メイン。
		*/
		public void TestMain()
		{
			for(long ii=0;ii<Config.MAX;ii++){
				this.action.Do(ref this.result);
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

