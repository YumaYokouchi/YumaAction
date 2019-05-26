using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleChanger : MonoBehaviour {
	bool isSlow;
	Camera cam;
	float color;
	// Use this for initialization
	void Start () {
		isSlow = false;
		cam = GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		color = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("o")){
			if (isSlow == true) {
				Time.timeScale = 1;
				isSlow = false;
				color = 0;
			} else if(isSlow == false){
				Time.timeScale = 0.5f;
				isSlow = true;
				color = 1;
			}

		}
		cam.backgroundColor = new Color(color, 0, 1, 1);
	}
	void TimeScaleChange(){
		
	}
}
