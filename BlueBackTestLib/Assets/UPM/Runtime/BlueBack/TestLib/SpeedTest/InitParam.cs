

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 速度テスト。
*/


/** BlueBack.TestLib.SpeedTest
*/
namespace BlueBack.TestLib.SpeedTest
{
	/** InitParam
	*/
	public struct InitParam
	{
		/** offset
		*/
		public UnityEngine.Vector2 offset;

		/** size
		*/
		public UnityEngine.Vector2 size;

		/** interval
		*/
		public float interval;

		/** font
		*/
		public string font_name;
		public int font_size;
		public bool font_bestfit;
		public UnityEngine.Color font_color;

		/** canvas
		*/
		public string canvas_name;

		/** camera
		*/
		public string camera_name;
		public UnityEngine.Color camera_bgcolor;
		public float camera_depth;

		/** CreateDefault
		*/
		public static InitParam CreateDefault()
		{
			return new InitParam(){
				offset = new UnityEngine.Vector2(0.0f,0.0f),
				size = new UnityEngine.Vector2(1.0f,0.2f),
				interval = 0.3f,
				font_name = "Arial.ttf",
				font_size = 22,
				font_bestfit = true,
				font_color = new UnityEngine.Color(1.0f,1.0f,1.0f,1.0f),
				canvas_name = "testlib_canvas",
				camera_name = "testlib_camera",
				camera_bgcolor = new UnityEngine.Color(0.0f,0.0f,0.0f,1.0f),
				camera_depth = 50.0f,
			};
		}
	}
}

