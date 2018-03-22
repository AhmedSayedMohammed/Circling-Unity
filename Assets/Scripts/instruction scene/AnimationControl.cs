using UnityEngine;
using System.Collections;

public class AnimationControl : MonoBehaviour {
	 Animator FirstAnimi;
	public AnimationClip a;

	int count ;
	void Start () {
		FirstAnimi = this.GetComponent<Animator> ();
		count = 0;
	}
	public void changeAnimi(){
		if (count == 0) {
			FirstAnimi.Play (a.name);

		}
}
}