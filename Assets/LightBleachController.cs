using UnityEngine;
using System.Collections;

public class LightBleachController : MonoBehaviour {


	public GameObject[] lightArray;
	public int lightToRender = 0;
	public bool increasingSlider = true;

	// Use this for initialization
	void Start () {
		lightArray = GameObject.FindGameObjectsWithTag("bleachLight");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGui() {

	}

	public void RenderLight (float newLightToRender){
		
		if (lightToRender < (int)newLightToRender) {
			increasingSlider = true;
		} else if(lightToRender > (int)newLightToRender) {
			increasingSlider = false;
		}

		lightToRender = (int)newLightToRender;

		Light currLight = lightArray [lightToRender].GetComponent<Light> ();

		if (increasingSlider) {
			currLight.enabled = true;
		} else if(!increasingSlider) {
			currLight.enabled = false;
		}
//		if (currLight.enabled) {
//			currLight.enabled = false;
//		} else {
//			currLight.enabled = true;
//		}

	}
}
