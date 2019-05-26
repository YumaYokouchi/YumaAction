using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject Target;
	float Timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (Timer > 1) {
			LookAt ();
		}

	}
	void LookAt(){
		this.transform.LookAt(Target.transform);
		Timer = 0;
	}
}
