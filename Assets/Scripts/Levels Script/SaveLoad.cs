using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SaveLoad : MonoBehaviour {

	// Use this for initialization


	public static void SaveLevel(int x){
		PlayerPrefs.SetInt ("LevelNumber", x);

	}
	public static int LoadLevel(){
		
	return	PlayerPrefs.GetInt ("LevelNumber");

	}

	public static void SaveLive(int x){
		PlayerPrefs.SetInt ("LiveNumber", x);

	}
	public static int LoadLive(){

		return	PlayerPrefs.GetInt ("LiveNumber");

	}

}
