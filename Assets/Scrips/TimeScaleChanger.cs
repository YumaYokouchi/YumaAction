using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleChanger : MonoBehaviour {
	Camera cam;
	float color;
	// Use this for initialization
	void Start () {
		GameManager.instance.nowSpeedState = GameManager.SpeedState.NORMAL;
		cam = GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		color = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("o")){
			if (GameManager.instance.nowSpeedState == GameManager.SpeedState.NORMAL) {
				Time.timeScale = 1;
				GameManager.instance.nowSpeedState = GameManager.SpeedState.SLOW;
				color = 0;
			} else if(GameManager.instance.nowSpeedState == GameManager.SpeedState.SLOW){
				Time.timeScale = 0.5f;
				GameManager.instance.nowSpeedState = GameManager.SpeedState.NORMAL;
				color = 1;
			}

		}
		cam.backgroundColor = new Color(color, 0, 1, 1);
	}
	void TimeScaleChange(){
		
	}
}
