using UnityEngine;
using System.Collections;

public class RandomDegree : MonoBehaviour {
	
	// Use this for initialization
	//public Animator Animi;
	//public AnimationClip clip;
	public int Random_degree;
	public float Random_Rotation=0;
	float start_rotation;
	float [] alldegree=new float[5];

	float x;
	void Awake () {
		alldegree [0] = 450;
		alldegree [1] = 90;
		alldegree [2] = 180;
		alldegree [3] = 270;

		Random_degree = Random.Range (0,3);	
		Random_Rotation = this.transform.eulerAngles.z ;
	}
	
	// Update is called once per frame
	void Update () {

		if (StartCounter.TIMER <= 0) {
			if (alldegree [Random_degree] >= Random_Rotation) {
				Random_Rotation += Time.deltaTime * 100;

				this.transform.eulerAngles = new Vector3 (this.transform.rotation.x, this.transform.rotation.y, Random_Rotation);	

			}
		}
	}
}
