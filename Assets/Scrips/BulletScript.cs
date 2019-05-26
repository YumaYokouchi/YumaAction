using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
	public float BulletSpped;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (-BulletSpped * Time.deltaTime, 0, 0);
		Destroy(this.gameObject,3f);
	}
}
