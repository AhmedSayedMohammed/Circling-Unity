using UnityEngine;
using System.Collections;

public class ScorePanelOpen : MonoBehaviour {

	Animator animi;
	public AnimationClip clip_open;

	// Use this for initialization
	void Start () {
		animi = this.GetComponent<Animator> ();
	}

	public void openAnimation(){
		animi.Play (clip_open.name);
	}
}
