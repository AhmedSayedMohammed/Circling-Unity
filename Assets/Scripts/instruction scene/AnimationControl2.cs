using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class AnimationControl2 : MonoBehaviour {

	Animator instruction;
	public AnimationClip [] b ;

	int count=0;
	void Start () {
		instruction = this.GetComponent<Animator> ();

			instruction.enabled = false;	
	}
	

	public void changeAnimi2(){
		instruction.enabled = true;
		if (count == 0)
			instruction.Play (b [0].name);
		else if (count == 1)
			instruction.Play (b [1].name);
		else if (count == 2)
			instruction.Play (b [2].name);
		else if (count == 3)
			instruction.Play (b [3].name);
		else if (count == 4)
			instruction.Play (b [4].name);
		else if (count == 5)
			SceneManager.LoadScene  (3);
			count++;
	}
}
