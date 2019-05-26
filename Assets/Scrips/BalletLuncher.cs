using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletLuncher : MonoBehaviour {
	
	public GameObject Bullet;
	float Timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (Timer > 5) {
			BulletShot ();
		}
	}
	void BulletShot (){
		Debug.Log ("SHOT!");
		Instantiate(Bullet,this.transform.position,Quaternion.identity);
		Timer = 0;
	}
}

	