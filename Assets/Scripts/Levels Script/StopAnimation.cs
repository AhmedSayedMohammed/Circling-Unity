using UnityEngine;
using System.Collections;

public class StopAnimation : MonoBehaviour {

	public Animator a;
	public AnimationClip clip;
	public AnimationClip clip2;
	public float time_to_start ;
	public float time_to_stop ;

	void Start () {

		time_to_start = StartCounter.TIMER+2;
		time_to_stop = time_to_start + 3;

		StartCoroutine (startAnimi ());
		StartCoroutine (stopAnimi ());


	}
	IEnumerator startAnimi(){
		
		yield return new WaitForSeconds (time_to_start);
		a.Play(clip.name);


	}
	IEnumerator stopAnimi(){

		yield return new WaitForSeconds (time_to_stop);
		a.applyRootMotion = true;
	}
}
