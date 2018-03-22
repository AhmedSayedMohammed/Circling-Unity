using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Touch : MonoBehaviour {
	public Text touch_count;
	public Text Timer;
	public Text Live_Mind;
	public static int LIVE_MIND;
	public float TIME_TO_RELOAD;
	public static float TIME_TO_RELOAD_static=60;
	public static float Time_to_reload;
	public static int count=0;
	public GameObject Canvas_Game_over;
	public GameObject All_canvas;
	//public GameObject Mind_icon;
	// Animator Mind_Animi;
	//public AnimationClip Mind_clipl;


	void Start(){

		LIVE_MIND = SaveLoad.LoadLive();
		TIME_TO_RELOAD_static=TIME_TO_RELOAD;
		Time_to_reload = TIME_TO_RELOAD;
		Live_Mind.text = "" +LIVE_MIND ;
//		Mind_Animi = Mind_icon.GetComponent<Animator> ();
	}
	void Update(){
		//count number Of touches
	      count = Rotate.touch_count;
		  touch_count.text = "Touch : " + count;
	
		//change Timer text
		//  Time_to_reload -= Time.deltaTime;
		  Timer.text ="Time : "+(int)Time_to_reload;
		//update Live Text
		Live_Mind.text=""+LIVE_MIND;
		if (LIVE_MIND <= 0) {
			Canvas_Game_over.SetActive (true);
			All_canvas.SetActive (false);
		}

		//check if time less than 10 to play mind animation
		if(Time_to_reload <= 10){
//			Mind_Animi.Play (Mind_clipl.name);
		}

	// Dont start until start counter finishes
		if (StartCounter.TIMER <= 0) {
			Time_to_reload -= Time.deltaTime;
		
		}
		//check if time finished 
		if (Time_to_reload <= 0) {
			LoadMenu.reloadCount++;
			LIVE_MIND = int.Parse (Live_Mind.text);
			if (LIVE_MIND > 0) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			} else {

				Canvas_Game_over.SetActive (true);
				All_canvas.SetActive (false);
			}
			// if time equal zero then subtract 1 else do nothing
			if(Time_to_reload <=0)
				LIVE_MIND--;
		}
	}

	IEnumerator countDown(){

		yield return new WaitForSeconds (Time_to_reload);

	}
}
