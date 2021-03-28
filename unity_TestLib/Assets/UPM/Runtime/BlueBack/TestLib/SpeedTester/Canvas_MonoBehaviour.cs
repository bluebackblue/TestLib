

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** Canvas_MonoBehaviour
	*/
	public class Canvas_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** callback
		*/
		public CallBackInterface callback;

		/** callback
		*/
		private void Start()
		{
			if(this.callback != null){
				this.callback.OnStart();
			}
		}
	}
}

