using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AllDegree : MonoBehaviour {
	public GameObject ScoreCanvas;
	public GameObject ActionCanvas;
	public GameObject [] zero_degree;
	public GameObject [] nighnteen_degree;
	public GameObject [] eighteen_degree;
	public GameObject [] two_seven_degree;

	bool [] is_zero_degree;
	bool [] is_nighnteen_degree ;
	bool [] is_eighteen_degree ;
	bool [] is_two_seven_degree ;
    public	Animator animi;
	public AnimationClip clip;
	int count_zero_degree = 0;
	int count_nighnteen_degree = 0;
	int count_eighteen_degree = 0;
	int count_two_seven_degree = 0;
	private float Increse_start_Time=3;

	// Update is called once per frame
	void Start(){


		 is_zero_degree=new bool[zero_degree.Length];
		 is_nighnteen_degree=new bool[nighnteen_degree.Length];
		 is_eighteen_degree = new bool[eighteen_degree.Length];
		 is_two_seven_degree=new bool[two_seven_degree.Length];
		Increse_start_Time += StartCounter.TIMER +1;
	}

	void Update (){
	 
		if (Increse_start_Time <= 0) {
			thisIsIt ();
			Debug.Log ("Done");
		} else {
			Increse_start_Time -= Time.deltaTime ;
		}
	}
	 void thisIsIt(){
		
		//0,360
		for (int i = 0; i < zero_degree.Length; i++) {
			if ((zero_degree [i].transform.localRotation.eulerAngles.z >= -10 && zero_degree [i].transform.rotation.eulerAngles.z <= 10) || (zero_degree [i].transform.rotation.eulerAngles.z >= 350)) {
				is_zero_degree [i] = true;
			} else
				is_zero_degree [i] = false;
		}

		//90
		for (int i = 0; i < nighnteen_degree.Length; i++) {
			if ((nighnteen_degree [i].transform.localRotation.eulerAngles.z >= 80 && nighnteen_degree [i].transform.rotation.eulerAngles.z <= 100)) {
				is_nighnteen_degree [i] = true;
			} else
				is_nighnteen_degree [i] = false;
		}
		//180
		for (int i = 0; i < eighteen_degree.Length; i++) {
			if ((eighteen_degree [i].transform.localRotation.eulerAngles.z >= 170 && eighteen_degree [i].transform.rotation.eulerAngles.z <= 190)) {
				is_eighteen_degree [i] = true;
			} else
				is_eighteen_degree [i] = false;
		}
		//270
		for (int i = 0; i < two_seven_degree.Length; i++) {
			if ((two_seven_degree [i].transform.localRotation.eulerAngles.z >= 260 && two_seven_degree [i].transform.rotation.eulerAngles.z <= 290)) {
				is_two_seven_degree [i] = true;
			} else {
				//Debug.Log (i);
				is_two_seven_degree [i] = false;

			}
		}
		//zero condition
		if (is_zero_degree.Length != count_zero_degree)
			for (int i = 0; i < is_zero_degree.Length; i++) {

				if (is_zero_degree [i] == true) {
					count_zero_degree++;
				} else {

					count_zero_degree = 0;
					break;
				}
			}
		//90 condition
		if (is_nighnteen_degree.Length != count_nighnteen_degree) {
			for (int i = 0; i < is_nighnteen_degree.Length; i++) {
				if (is_nighnteen_degree [i] == true) {
					count_nighnteen_degree++;
				} else {

					count_nighnteen_degree = 0;
					break;
				}
			}
		}
		//270 condition
		if (is_two_seven_degree.Length != count_two_seven_degree)
			for (int i = 0; i < is_two_seven_degree.Length; i++) {

				if (is_two_seven_degree [i] == true) {
					count_two_seven_degree++;
				} else {

					count_two_seven_degree = 0;
					break;
				}
			}
		//180 condition
		if (is_eighteen_degree.Length != count_eighteen_degree)
			for (int i = 0; i < is_eighteen_degree.Length; i++) {

				if (is_eighteen_degree [i] == true) {
					count_eighteen_degree++;
				} else {

					count_eighteen_degree = 0;
					break;
				}
			}
		if (is_zero_degree.Length == count_zero_degree && is_nighnteen_degree.Length == count_nighnteen_degree && is_eighteen_degree.Length == count_eighteen_degree && is_two_seven_degree.Length == count_two_seven_degree) {

			ScoreCanvas.SetActive (true);
			ActionCanvas.SetActive (false);
		} 

		 // Debug.Log ("is" + is_zero_degree.Length);
		//  Debug.Log ("count 90  :" + count_nighnteen_degree);
		//  Debug.Log ("count0  :" + count_zero_degree);
		//  Debug.Log ("count180  :" + count_eighteen_degree);
		 // Debug.Log ("count270  :" + count_two_seven_degree);

	}
		

}

