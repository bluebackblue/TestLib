

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** Canvas_MonoBehaviour
	*/
	public sealed class Canvas_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** callback
		*/
		public CallBack_Base callback;

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

