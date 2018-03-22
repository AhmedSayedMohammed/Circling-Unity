using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreCanvas : MonoBehaviour {
	public Text Touch_count;
	public Text Reload_count;
	public Text Memory;
	public int Least_Touch_Number;
	public Text Time_to_reload;
	public Text Live_Won;

	void Start () {
		Touch_count.text = " " + Touch.count;
		Reload_count.text = "" + LoadMenu.reloadCount;

		int time_percent = (int)Touch.Time_to_reload * 100 / (int)Touch.TIME_TO_RELOAD_static;
	
		Memory.text = " " + time_percent + " %";

		if (time_percent >= 90) {
			Touch.LIVE_MIND += 3;
			Live_Won.text = " " + 3;

		} else if (time_percent >= 80) {
			Touch.LIVE_MIND += 2;
			Live_Won.text = " " + 2;

		} else if (time_percent >= 70) {
			Touch.LIVE_MIND += 1;   
			Live_Won.text = " " + 1;
		} else {
			Live_Won.text = "  0";
		}
	
		int x=SceneManager.GetActiveScene ().buildIndex+1;
		SaveLoad.SaveLevel (x);
		SaveLoad.SaveLive (Touch.LIVE_MIND);
	}


}
