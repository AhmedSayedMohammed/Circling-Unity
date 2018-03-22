using UnityEngine;
using System.Collections;

public class AnimiDegree : MonoBehaviour {

	public GameObject Degree;
	public AnimationClip a;
    private float Degree_Scale=0.1f;
   

    // when player let button
    void OnMouseUp()
	{
		var Dgr = Instantiate (Degree.gameObject);
		Dgr.transform.SetParent (this.transform);
        Dgr.transform.localScale=new Vector3(Degree_Scale, Degree_Scale, Degree_Scale);
		Destroy (Dgr.gameObject, a.length);
	}

}

