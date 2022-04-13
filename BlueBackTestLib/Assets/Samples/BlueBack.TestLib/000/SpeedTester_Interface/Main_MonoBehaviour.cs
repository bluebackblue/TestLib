

/** BlueBack.TestLib.Samples.SpeedTester_Interface
*/
namespace BlueBack.TestLib.Samples.SpeedTester_Interface
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** speedtester
		*/
		private BlueBack.TestLib.SpeedTester.SpeedTester speedtester;

		/** Start
		*/
		private void Start()
		{
			this.speedtester = new BlueBack.TestLib.SpeedTester.SpeedTester(new BlueBack.TestLib.SpeedTester.Test_Base[]{
				new Test_Interface(),
				new Test_Class(),
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

