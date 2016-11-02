using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class switchScene : MonoBehaviour {

	public void onBtnClicked(int sceneToChangeTo){
		SceneManager.LoadScene (sceneToChangeTo);
	}
}
