using UnityEngine;
using System.Collections;

public class SoundControl : MonoBehaviour {

	 AudioSource audioRotatting;
	private float TimeToStartSound = 3;
	void Start () {

	    audioRotatting=this.GetComponent<AudioSource> ();
		TimeToStartSound =StartCounter.TIMER;
		StartCoroutine (startaudio ());
	}

	IEnumerator startaudio(){
		yield return new WaitForSeconds (TimeToStartSound);
		audioRotatting.Play ();
	}
}
