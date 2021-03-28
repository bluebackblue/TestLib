

/** BlueBack.TestLib
*/
namespace BlueBack.TestLib
{
	/** Config
	*/
	public class Config
	{
		/** Hierarchy上の名前。
		*/
		public string CAMERA_NAME;

		/** 色。
		*/
		public UnityEngine.Color CAMERA_COLOR;

		/** 描画順序。
		*/
		public float CAMERA_DEPTH;

		/** Hierarchy上の名前。
		*/
		public string CANVAS_NAME;

		/**　リスト最大数。
		*/
		public int CANVAS_MAX;

		/**　フォントサイズ。
		*/
		public int CANVAS_FONTSIZE;

		/** フォントサイズのベストフィット設定。
		*/
		public bool CANVAS_FONTBESTFIT;

		/** 色。
		*/
		public UnityEngine.Color CANVAS_FONTCOLOR;

		/** 表示位置とサイズ。
		*/
		public float CANVAS_TEXT_W;
		public float CANVAS_TEXT_H;
		public float CANVAS_TEXT_OFFSET_X;
		public float CANVAS_TEXT_OFFSET_Y;

		/** constructor
		*/
		public Config()
		{
			this.CAMERA_NAME = "TestLib_Camera";
			this.CAMERA_COLOR = new UnityEngine.Color(0.0f,0.0f,0.0f,1.0f);
			this.CAMERA_DEPTH = 50.0f;
			this.CANVAS_NAME = "TestLib_Canvas";
			this.CANVAS_MAX = 10;
			this.CANVAS_FONTSIZE = 22;
			this.CANVAS_FONTBESTFIT = true;
			this.CANVAS_FONTCOLOR = new UnityEngine.Color(0.5f,0.5f,0.5f,1.0f);
			this.CANVAS_TEXT_W = 0.8f;
			this.CANVAS_TEXT_H = 0.07f;
			this.CANVAS_TEXT_OFFSET_X = 0.05f;
			this.CANVAS_TEXT_OFFSET_Y = 0.05f;
		}
	}
}

