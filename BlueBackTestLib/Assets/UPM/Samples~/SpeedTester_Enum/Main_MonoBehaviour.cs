

/** BlueBack.TestLib.Samples.SpeedTester_Enum
*/
namespace BlueBack.TestLib.Samples.SpeedTester_Enum
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
				new Test_ConstInt(),
				new Test_Enum(),
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

