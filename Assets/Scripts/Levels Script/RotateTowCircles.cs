using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class RotateTowCircles : MonoBehaviour {

	public GameObject Halfe_Circle_follower;

	public float ROTATE_DEGREE = 90;
	public float Halfe_Circle_Follower_Degree=30;
	public AudioSource tick;

	void Awake(){
		tick.Stop ();
	}

	void OnMouseUp ()
	{       

		if (!EventSystem.current.IsPointerOverGameObject ()) {
				Rotate.touch_count++;
				tick.Play ();
				float x = (int)this.transform.rotation.z + ROTATE_DEGREE;
				this.transform.Rotate (new Vector3 (0, 0, x));
				Halfe_Circle_follower.transform.Rotate (new Vector3 (0, 0, Halfe_Circle_Follower_Degree));
		

		}
	}


}
