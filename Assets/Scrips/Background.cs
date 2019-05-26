using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	Camera cam;
	float color;

	void Start () {
		cam = GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
	}

	void Update () {
		color += Time.deltaTime;

		if(color > 1)
		{
			color = 0;
		}

		cam.backgroundColor = new Color(color, 0, 1, 1);
	}
}