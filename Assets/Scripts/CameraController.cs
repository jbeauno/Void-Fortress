using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float speedCam = 3;
	public float speedZoom = 40;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float movDrG = Input.GetAxis ("Horizontal");
		float movHB = -Input.GetAxis ("Vertical");
		float zoom = Input.GetAxis ("Mouse ScrollWheel");
		Vector3 posCam;

		transform.Translate (movHB* Time.deltaTime* speedCam, 0,movDrG* Time.deltaTime* speedCam, Space.World);
		posCam = transform.position;
		if (posCam.x > 7)
			posCam.x = 7; 
		if (posCam.x < -7)
			posCam.x = -7; 
		if (posCam.z > 13)
			posCam.z = 13; 
		if (posCam.z < -13)
			posCam.z = -13; 
		transform.position = posCam;

		if ((posCam.y > 1) && (zoom > 0)) {
			transform.Translate (0, 0, zoom * Time.deltaTime * speedZoom * posCam.y);
			posCam = transform.position;
		}
		if ((posCam.y < 10) && (zoom < 0)) {
			transform.Translate (0, 0, zoom * Time.deltaTime * speedZoom * posCam.y);
			posCam = transform.position;
		}
		if (posCam.y > 10)
			posCam.y = 10; 
		if (posCam.y < 1)
			posCam.y = 1; 

		transform.position = posCam;

	}
}
