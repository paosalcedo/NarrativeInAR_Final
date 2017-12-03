using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		var myCam = Camera.main.transform;

			//rotate camera based on mouse delta speed
		myCam.Rotate (-Input.GetAxis ("Mouse Y"), Input.GetAxis ("Mouse X"), 0f);

			//unroll our camera
		myCam.localEulerAngles = new Vector3 (myCam.localEulerAngles.x, myCam.localEulerAngles.y, 0f); 

	}
}
