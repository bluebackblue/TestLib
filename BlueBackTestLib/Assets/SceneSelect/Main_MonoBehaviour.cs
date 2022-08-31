

/** SceneSelect
*/
namespace SceneSelect
{
	/** Main_MonoBehaviour
	*/
	public class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** name_list
		*/
		public string[] name_list;

		/** ui_list
		*/
		public UnityEngine.UI.Text[] ui_list;

		/** index
		*/
		public int index;
		public int index_old;

		/** scene
		*/
		public bool scene_flag;
		public string scene_path;

		/** Start
		*/
		void Start()
		{
			//index
			this.index = 0;
			this.index_old = -1;

			//text
			UnityEngine.UI.Text t_text_0 = UnityEngine.GameObject.Find("text_0").GetComponent<UnityEngine.UI.Text>();
			UnityEngine.UI.Text t_text_1 = UnityEngine.GameObject.Find("text_1").GetComponent<UnityEngine.UI.Text>();

			//interval
			float t_interval = t_text_1.rectTransform.anchoredPosition.y - t_text_0.rectTransform.anchoredPosition.y;

			//ui_list
			this.ui_list = new UnityEngine.UI.Text[this.name_list.Length];
			for(int ii=0;ii<this.ui_list.Length;ii++){
				if(ii == 0){
					this.ui_list[ii] = t_text_0;
				}else if(ii == 1){
					this.ui_list[ii] = t_text_1;
				}else{
					UnityEngine.UI.Text t_text =  UnityEngine.GameObject.Instantiate(t_text_0,t_text_0.transform.parent);
					this.ui_list[ii] = t_text;
					t_text.rectTransform.anchoredPosition = t_text_0.rectTransform.anchoredPosition + new UnityEngine.Vector2(0.0f,t_interval * ii);
				}

				//text
				this.ui_list[ii].text = this.name_list[ii];
			}

			//scene
			this.scene_flag = false;
			this.scene_path = null;
		}

		/** Inner_SetVisible
		*/
		private void Inner_SetVisible(bool a_flag)
		{
			for(int ii=0;ii<this.ui_list.Length;ii++){
				this.ui_list[ii].gameObject.SetActive(a_flag);
			}
		}

		/** Update
		*/
		void Update()
		{
			if(this.scene_flag == false){
				//Input
				if(UnityEngine.Input.GetKeyUp(UnityEngine.KeyCode.UpArrow) == true){
					this.index--;
					if(this.index < 0){
						this.index = 0;
					}
				}else if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.DownArrow) == true){
					this.index++;
					if(this.index >= this.ui_list.Length){
						this.index = this.ui_list.Length - 1;
					}
				}else if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Return) == true){
					this.scene_flag = true;
					this.scene_path = string.Format("Samples/BlueBack.TestLib/000/{0}/Scene",this.name_list[this.index]);
					UnityEngine.SceneManagement.SceneManager.LoadScene(this.scene_path,UnityEngine.SceneManagement.LoadSceneMode.Additive);
					this.Inner_SetVisible(false);
				}

				//color
				if(this.index != this.index_old){
					this.index_old = this.index;
					for(int ii=0;ii<this.ui_list.Length;ii++){
						if(ii == this.index){
							this.ui_list[ii].color = new UnityEngine.Color(1.0f,0.0f,0.0f,1.0f);
						}else{
							this.ui_list[ii].color = new UnityEngine.Color(1.0f,1.0f,1.0f,1.0f);
						}
					}
				}
			}else{
				//Input
				if(UnityEngine.Input.GetKeyDown(UnityEngine.KeyCode.Return) == true){
					this.scene_flag = false;
					this.Inner_SetVisible(true);
					UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(this.scene_path);
				}
			}
		}
	}
}

