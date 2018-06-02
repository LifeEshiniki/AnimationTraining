using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	float zoomSpeed = 2f;
	public GameObject looking;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt (looking.transform.position);

		if (Input.GetKey (KeyCode.A) ){
			this.transform.RotateAround (looking.transform.position,looking.transform.up,2f);
		}
		if (Input.GetKey (KeyCode.D)) {
			this.transform.RotateAround (looking.transform.position,looking.transform.up,-2f);
		}
		if (Input.GetKey (KeyCode.W)) {
			Camera.main.fieldOfView +=  zoomSpeed;
		}
		if(Input.GetKey (KeyCode.S)){
			Camera.main.fieldOfView -=  zoomSpeed;
		}
		if (Camera.main.fieldOfView < 10) {
			Camera.main.fieldOfView = 10;
		}
		if (Camera.main.fieldOfView > 100) {
			Camera.main.fieldOfView = 100;
		}
	}


}
