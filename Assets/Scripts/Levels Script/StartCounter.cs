using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StartCounter : MonoBehaviour {
	public Text startcounter;
	public float timer=3;
	public static float TIMER;
	public AudioSource Audio;
	void Awake(){
		TIMER = timer;
	}
	void Update () {
		
		if (timer > 0) {
			timer-= Time.deltaTime;
			startcounter.text = "" + (int)timer;
			TIMER = timer;

		} else {
			startcounter.enabled = false;
		}
	}

}
