using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
	public float BulletSpped;
	public GameObject Target;
	// Use this for initialization
	void Start () {
		Target = GameObject.Find ("Player");
		this.transform.LookAt(Target.transform);
		Destroy(this.gameObject,3f);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += transform.forward * Time.deltaTime *BulletSpped;
	}
}
