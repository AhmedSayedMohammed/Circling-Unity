using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class FaddingScript : MonoBehaviour {
	public Text level_num=null;
	public static int x=2;


	void Start () {
		//data = new SaveData(fileName);
		x=SaveLoad.LoadLevel();
		Debug.Log ("fadding script x  is: " + x);
		level_num.text+=""+(x-2);
		StartCoroutine (Fad ());
	}

	IEnumerator Fad(){
		
		yield return new WaitForSeconds (5);

	

		SceneManager.LoadScene (x);
		Debug.Log ("x is ( fdding script ) : " + x);

	
	}

	public void getCurrentLevelIndex(){

		x = SceneManager.GetActiveScene ().buildIndex;
	
	}

}
