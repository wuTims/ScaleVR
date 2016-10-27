using UnityEngine;
using System.Collections;

public class GrowCylinder : MonoBehaviour {

	public float height = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3 (transform.localScale.x, height, transform.localScale.z);
	}

	void OnGui() {
		
	}

	public void AdjustHeight (float newHeight){
		height = newHeight;
	}
}
