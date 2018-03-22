using UnityEngine;
using System.Collections;

public class ParticularDegree : MonoBehaviour {
	
	public float particulare_Rotation=0;
	private float start_rotation=0;

	
	// Update is called once per frame
	void Update () {
		if (StartCounter.TIMER <= 0) {
			if ( particulare_Rotation>= start_rotation) {
				start_rotation += Time.deltaTime * 100;

				this.transform.eulerAngles = new Vector3 (this.transform.rotation.x, this.transform.rotation.y, start_rotation);	

			}
		}
	}
}
