using System.Collections;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

		public Button Reload;

	// Use this for initialization

	public void Restart (){
		SceneManager.LoadScene("GameScene");
	}
}
