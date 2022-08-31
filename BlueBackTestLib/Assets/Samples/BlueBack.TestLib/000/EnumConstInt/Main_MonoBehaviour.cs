

/** BlueBack.TestLib.Samples.EnumConstInt
*/
namespace BlueBack.TestLib.Samples.EnumConstInt
{
	/** Main_MonoBehaviour
	*/
	public sealed class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** speedtest
		*/
		private BlueBack.TestLib.SpeedTest.SpeedTest speedtest;

		/** Start
		*/
		private void Start()
		{
			BlueBack.TestLib.SpeedTest.InitParam t_initparam = BlueBack.TestLib.SpeedTest.InitParam.CreateDefault();
			{
			}

			this.speedtest = new BlueBack.TestLib.SpeedTest.SpeedTest(in t_initparam,new BlueBack.TestLib.SpeedTest.Test_Base[]{
				new Test_ConstInt(),
				new Test_Enum(),
			});
		}

		/** Update
		*/
		private void Update()
		{
			if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.UpArrow) == true){
				Config.MAX *= 10;
			}else if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.DownArrow) == true){
				Config.MAX = UnityEngine.Mathf.Max(10,Config.MAX /= 10);
			}

			if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.PageUp) == true){
				this.speedtest.view.offset.y -= 0.1f;
				this.speedtest.ApplyPosition();
			}else if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.PageDown) == true){
				this.speedtest.view.offset.y += 0.1f;
				this.speedtest.ApplyPosition();
			}

			this.speedtest.RandomTest(Config.TESTLOOP);
		}

		/** OnDestroy
		*/
		private void OnDestroy()
		{
			if(this.speedtest != null){
				this.speedtest.Dispose();
				this.speedtest = null;
			}
		}
	}
}

