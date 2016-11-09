using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagerTool : MonoBehaviour {
	public static SceneManagerTool Instance{ set; get; }

	private void Awake() {
		Instance = this;
		Load ("Player");
		Load ("Scene1");
		//Load ("Bridge");
		//Load ("Scene2");

	}

	public void Load (string sceneName) {
		if (!SceneManager.GetSceneByName(sceneName).isLoaded) {
			SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
		}
	}

	public void Unload(string sceneName){
		if (SceneManager.GetSceneByName(sceneName).isLoaded) {
			SceneManager.UnloadScene(sceneName);
		}
	}

}
