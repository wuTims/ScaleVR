using UnityEngine;
using System.Collections;

public class LoadTrigger : MonoBehaviour {

	public string loadName;
	public string unloadName;

	private void OnTriggerEnter (Collider col){
		if (!loadName.Equals ("")) {
			SceneManagerTool.Instance.Load (loadName);
		}

		if (!unloadName.Equals ("")) {
			StartCoroutine ("UnloadScene");
		}
	}

	IEnumerator UnloadScene(){
		yield return new WaitForSeconds (.10f);
		SceneManagerTool.Instance.Unload (unloadName);
	}
}
