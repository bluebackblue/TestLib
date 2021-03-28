

/** Scenes
*/
namespace Scenes
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** t_speedtester
		*/
		private BlueBack.TestLib.SpeedTester.SpeedTester speedtester;

		/** Start
		*/
		private void Start()
		{
			this.speedtester = new BlueBack.TestLib.SpeedTester.SpeedTester(new BlueBack.TestLib.SpeedTester.ITest[]{
				new Test00(),
			});
		}

		/** Update
		*/
		private void Update()
		{
			this.speedtester.RandomTest();
		}

		/** OnDestroy
		*/
		private void OnDestroy()
		{
			if(this.speedtester != null){
				this.speedtester.Delete();
				this.speedtester = null;
			}
		}
	}
}

