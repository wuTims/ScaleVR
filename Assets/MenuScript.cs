using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas aboutTheGameMenu;
	public Button startText;
	public Button exitText;



	// Use this for initialization
	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas> ();
		aboutTheGameMenu = aboutTheGameMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		aboutTheGameMenu.enabled = false;
	}

	public void AboutTheGameMenuPress(){
		quitMenu.enabled = false;
		startText.enabled = false;
		exitText.enabled = false;
		aboutTheGameMenu.enabled = true;
	}


	public void ExitPress(){
	
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	
	}
	public void NoPress(){
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		aboutTheGameMenu.enabled = false;

	}


	public void StartGame(){
	
		SceneManager.LoadScene ("Scene1");
	
	}

	public void ExitGame(){

		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
