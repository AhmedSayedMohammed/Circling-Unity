using UnityEngine;
using System.Collections;

public class ContinueButton : MonoBehaviour {
	public GameObject continuebutton;
	// Use this for initialization
	void Start () {


		int x = SaveLoad.LoadLevel();
	

		if (x > 3) {
			continuebutton.SetActive (true);
		}else
			continuebutton.SetActive (false);
	}

}
