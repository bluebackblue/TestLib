

/** Scenes
*/
namespace Scenes
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** t_testlib
		*/
		TestLib.TestLib t_testlib;

		/** Start
		*/
		private void Start()
		{
			this.t_testlib = new TestLib.TestLib(new TestLib.Test_Base[]{
				new Test00(),
			});
		}

		/** Update
		*/
		private void Update()
		{
			this.t_testlib.RandomTest();
		}

		/** OnDestroy
		*/
		private void OnDestroy()
		{
			if(this.t_testlib != null){
				this.t_testlib.Delete();
				this.t_testlib = null;
			}
		}
	}
}

