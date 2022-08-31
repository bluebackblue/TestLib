

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 速度テスト。
*/


/** BlueBack.TestLib.SpeedTest
*/
namespace BlueBack.TestLib.SpeedTest
{
	/** View
	*/
	public sealed class View : System.IDisposable
	{
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
		public View(in InitParam a_initparam,int a_max)
		{
			//gameobject
			this.camera_gameobject = new UnityEngine.GameObject(a_initparam.camera_name);
			UnityEngine.GameObject.DontDestroyOnLoad(this.camera_gameobject);
			this.canvas_gameobject = new UnityEngine.GameObject(a_initparam.canvas_name);
			UnityEngine.GameObject.DontDestroyOnLoad(this.canvas_gameobject);

			//Camera
			UnityEngine.Camera t_camera = this.camera_gameobject.AddComponent<UnityEngine.Camera>();
			{
				t_camera.Reset();
				t_camera.clearFlags = UnityEngine.CameraClearFlags.SolidColor;
				t_camera.backgroundColor = a_initparam.camera_bgcolor;
				t_camera.depth = a_initparam.camera_depth;
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
				UnityEngine.Font t_font = UnityEngine.Resources.GetBuiltinResource<UnityEngine.Font>(a_initparam.font_name);
				UnityEngine.Vector2 t_position = a_initparam.offset * new UnityEngine.Vector2(UnityEngine.Screen.width,UnityEngine.Screen.height);
				UnityEngine.Vector2 t_size =  a_initparam.size * new UnityEngine.Vector2(UnityEngine.Screen.width,UnityEngine.Screen.height);
				float t_interval = a_initparam.interval * UnityEngine.Screen.height;

				this.text_list = new UnityEngine.UI.Text[a_max];
				for(int ii=0;ii<this.text_list.Length;ii++){
					UnityEngine.GameObject t_text_gameobject = new UnityEngine.GameObject("text");
					t_text_gameobject.transform.SetParent(this.canvas_gameobject.transform);

					t_position.y += t_interval;

					UnityEngine.UI.Text t_text = t_text_gameobject.AddComponent<UnityEngine.UI.Text>();
					this.text_list[ii] = t_text;
					{
						t_text.text = ii.ToString();
						t_text.fontSize = a_initparam.font_size;
						t_text.resizeTextForBestFit = a_initparam.font_bestfit;
						t_text.font = t_font;
						t_text.color = a_initparam.font_color;
						t_text.alignment = UnityEngine.TextAnchor.UpperLeft;
						t_text.rectTransform.localPosition = new UnityEngine.Vector3(0.0f,0.0f,0.0f);
						t_text.rectTransform.rotation = UnityEngine.Quaternion.identity;
						t_text.rectTransform.pivot = new UnityEngine.Vector2(0.0f,0.0f);
						t_text.rectTransform.anchorMin = new UnityEngine.Vector2(0.0f,1.0f);
						t_text.rectTransform.anchorMax = new UnityEngine.Vector2(0.0f,1.0f);
						t_text.rectTransform.localScale = new UnityEngine.Vector3(1.0f,1.0f,1.0f);
						t_text.rectTransform.sizeDelta = t_size;
						t_text.rectTransform.anchoredPosition = new UnityEngine.Vector2(t_position.x,-t_position.y);
					}
				}
			}
		}

		/** [System.IDisposable]破棄。
		*/
		public void Dispose()
		{
			if(this.camera_gameobject != null){
				UnityEngine.GameObject.DestroyImmediate(this.camera_gameobject);
				this.camera_gameobject = null;
			}

			if(this.canvas_gameobject != null){
				UnityEngine.GameObject.DestroyImmediate(this.canvas_gameobject);
				this.canvas_gameobject = null;
			}
		}
	}
}

