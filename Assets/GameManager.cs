using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public enum SpeedState	{
		NORMAL,
		SLOW
	}
	public SpeedState nowSpeedState;

	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);

		} else {
			Destroy (this.gameObject);
		}
	}
}
