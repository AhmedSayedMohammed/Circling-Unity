using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Rotate : MonoBehaviour {
	public float ROTATE_DEGREE = 90;
	public static int touch_count=0;
	public AudioSource tick;
	void Awake(){
		tick.Stop ();
	}
	void Start(){
		touch_count = 0;
	}
	void OnMouseUp ()
	{       
		if (StartCounter.TIMER <= 0) {
		
			if (!EventSystem.current.IsPointerOverGameObject ()) {
				touch_count++;
				tick.Play ();
				float x = (int)this.transform.rotation.z + ROTATE_DEGREE;
				this.transform.Rotate (new Vector3 (0, 0, x));
			}
		}
	}
}