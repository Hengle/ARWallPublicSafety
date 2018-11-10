using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARWallMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		EmailManager email = transform.Find("Service/Email").GetComponent<EmailManager>();
		CameraScreenCapture cameraCapture = transform.Find("Service/ScreenShot").GetComponent<CameraScreenCapture>();

		cameraCapture.SetUp(Camera.main);
		email.SetUp(cameraCapture);
	}

}
