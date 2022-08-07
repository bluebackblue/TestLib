

/** BlueBack.TestLib.Samples.SpeedTester_FloatInt
*/
namespace BlueBack.TestLib.Samples.SpeedTester_FloatInt
{
	/** Main_MonoBehaviour
	*/
	public sealed class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** speedtester
		*/
		private BlueBack.TestLib.SpeedTester.SpeedTester speedtester;

		/** Start
		*/
		private void Start()
		{
			this.speedtester = new BlueBack.TestLib.SpeedTester.SpeedTester(new BlueBack.TestLib.SpeedTester.Test_Base[]{
				new Test_Float(),
				new Test_Int(),
			});
		}

		/** Update
		*/
		private void Update()
		{
			this.speedtester.RandomTest(Config.LOOP);
		}
	}
}

