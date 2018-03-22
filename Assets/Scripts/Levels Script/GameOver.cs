using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {

	public GameObject Canvas_Game_over;
	public GameObject All_canvas;
	public void resetLevelAfterGameOver(){
		Canvas_Game_over.SetActive (false);
		Canvas_Game_over.SetActive (true);

		resetLevel ();
	}
	public static void resetLevel(){
		
		FaddingScript.x=3;
		SaveLoad.SaveLevel (3);
		Touch.LIVE_MIND = 3;
		SaveLoad.SaveLive (3);
	}

}
