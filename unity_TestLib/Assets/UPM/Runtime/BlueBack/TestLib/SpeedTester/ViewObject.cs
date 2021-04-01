

/** BlueBack.TestLib.SpeedTester
*/
namespace BlueBack.TestLib.SpeedTester
{
	/** ViewObject
	*/
	public class ViewObject : CallBackInterface
	{
		/** param
		*/
		private Param param;

		/** camera
		*/
		private UnityEngine.GameObject camera_gameobject;

		/** canvas
		*/
		private UnityEngine.GameObject canvas_gameobject;

		/** text_list
		*/
		public UnityEngine.UI.Text[] text_list;

		/** constructor
		*/
		public ViewObject(Param a_param,int a_max)
		{
			//param
			this.param = a_param;

			//gameobject
			this.camera_gameobject = new UnityEngine.GameObject(a_param.camera_name);
			UnityEngine.GameObject.DontDestroyOnLoad(this.camera_gameobject);
			this.canvas_gameobject = new UnityEngine.GameObject(a_param.canvas_name);
			UnityEngine.GameObject.DontDestroyOnLoad(this.canvas_gameobject);

			//Canvas_MonoBehaviour
			Canvas_MonoBehaviour t_canvas_monobehaviour = this.canvas_gameobject.AddComponent<Canvas_MonoBehaviour>();
			{
				t_canvas_monobehaviour.callback = this;
			}

			//Camera
			UnityEngine.Camera t_camera = this.camera_gameobject.AddComponent<UnityEngine.Camera>();
			{
				t_camera.Reset();
				t_camera.clearFlags = UnityEngine.CameraClearFlags.SolidColor;
				t_camera.backgroundColor = a_param.camera_color;
				t_camera.depth = a_param.camera_depth;
			}

			//Canvas
			UnityEngine.Canvas t_canvas = this.canvas_gameobject.AddComponent<UnityEngine.Canvas>();
			{
				t_canvas.renderMode = UnityEngine.RenderMode.ScreenSpaceCamera;
				t_canvas.worldCamera = t_camera;
			}

			//CanvasScaler
			UnityEngine.UI.CanvasScaler t_canvasscaler = this.canvas_gameobject.AddComponent<UnityEngine.UI.CanvasScaler>();
			{
				t_canvasscaler.uiScaleMode = UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize;
				t_canvasscaler.referenceResolution = new UnityEngine.Vector2(UnityEngine.Screen.width,UnityEngine.Screen.height);
			}

			//Text
			{
				UnityEngine.Font t_font = UnityEngine.Resources.GetBuiltinResource<UnityEngine.Font>("Arial.ttf");

				this.text_list = new UnityEngine.UI.Text[a_max];
				for(int ii=0;ii<this.text_list.Length;ii++){

					UnityEngine.GameObject t_text_gameobject = new UnityEngine.GameObject("text");
					t_text_gameobject.transform.SetParent(this.canvas_gameobject.transform);

					UnityEngine.UI.Text t_text = t_text_gameobject.AddComponent<UnityEngine.UI.Text>();
					this.text_list[ii] = t_text;
					{
						t_text.text = ii.ToString();
						t_text.fontSize = a_param.canvas_fontsize;
						t_text.resizeTextForBestFit = true;
						t_text.font = t_font;
						t_text.color = a_param.canvas_fontcolor;
						t_text.alignment = UnityEngine.TextAnchor.UpperLeft;
					}
				}
			}
		}

		/** OnStart
		*/
		public void OnStart()
		{
			for(int ii=0;ii<text_list.Length;ii++){
				
				float t_x = UnityEngine.Screen.width * this.param.canvas_text_offset_x;
				float t_y = UnityEngine.Screen.height * (this.param.canvas_text_offset_y + ii * this.param.canvas_text_h);
				float t_w = UnityEngine.Screen.width * this.param.canvas_text_w;
				float t_h = UnityEngine.Screen.height * this.param.canvas_text_h;
				
				UnityEngine.UI.Text t_text = this.text_list[ii];
				t_text.rectTransform.localScale = new UnityEngine.Vector3(1.0f,1.0f,1.0f);
				t_text.rectTransform.sizeDelta = new UnityEngine.Vector2(t_w,t_h);
				t_text.rectTransform.localPosition = new UnityEngine.Vector3(t_x + t_w * 0.5f - UnityEngine.Screen.width * 0.5f,-t_y - t_h * 0.5f + UnityEngine.Screen.height * 0.5f,0.0f);
			}
		}

		/** 削除。
		*/
		public void Delete()
		{
			if(this.camera_gameobject != null){
				UnityEngine.GameObject.DestroyImmediate(this.camera_gameobject);
				this.camera_gameobject = null;
			}
		}
	}
}

