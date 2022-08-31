

/** BlueBack.TestLib.Samples.InspectorSelection
*/
namespace BlueBack.TestLib.Samples.InspectorSelection
{
	/** Test_Cache
	*/
	public sealed class Test_Cache : BlueBack.TestLib.SpeedTest.Test_Base
	{
		/** result
		*/
		private long result;

		/** count
		*/
		private int count;

		/** average
		*/
		private float average;

		/** target
		*/
		private UnityEngine.GameObject target;

		/** constructor
		*/
		public Test_Cache()
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
			#if(UNITY_EDITOR)

			//target
			this.target = UnityEditor.Selection.activeGameObject;

			//result
			this.result = 0;

			#endif
		}

		/** [BlueBack.TestLib.SpeedTest.Test_Base]メイン。
		*/
		public void TestMain()
		{
			#if(UNITY_EDITOR)

			UnityEngine.GameObject t_active_gameobject = UnityEditor.Selection.activeGameObject;
			for(long ii=0;ii<Config.MAX;ii++){
				if(t_active_gameobject == this.target){
					this.result++;
				}
			}

			#endif
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

