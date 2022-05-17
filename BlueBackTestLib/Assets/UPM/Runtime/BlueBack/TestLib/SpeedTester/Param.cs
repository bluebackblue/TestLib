

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** Param
	*/
	public sealed class Param
	{
		/** camera
		*/
		public string camera_name;
		public UnityEngine.Color camera_color;
		public float camera_depth;
		
		/** canvas
		*/
		public string canvas_name;
		public int canvas_fontsize;
		public bool canvas_fontbestfit;
		public UnityEngine.Color canvas_fontcolor;
		public float canvas_text_w;
		public float canvas_text_h;
		public float canvas_text_offset_x;
		public float canvas_text_offset_y;

		/** constructor
		*/
		public Param()
		{
			this.camera_name = "TestLib_Camera";
			this.camera_color = new UnityEngine.Color(0.0f,0.0f,0.0f,1.0f);
			this.camera_depth = 50.0f;
			this.canvas_name = "TestLib_Canvas";
			this.canvas_fontsize = 22;
			this.canvas_fontbestfit = true;
			this.canvas_fontcolor = new UnityEngine.Color(0.5f,0.5f,0.5f,1.0f);
			this.canvas_text_w = 0.8f;
			this.canvas_text_h = 0.07f;
			this.canvas_text_offset_x = 0.05f;
			this.canvas_text_offset_y = 0.05f;
		}
	}
}

