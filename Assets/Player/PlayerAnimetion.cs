using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimetion : MonoBehaviour {
	Animator animator;

	private bool isMove;
	// Use this for initialization
	void Start () {
		animator = this.gameObject.GetComponent<Animator>();

		isMove = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown("space")){
			animator.SetBool("Skill1Bool",true);
			animator.SetBool("Skill2Bool",true);
			animator.SetBool("Skill3Bool",true);
		}
	}
}
