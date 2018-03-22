using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadMenu : MonoBehaviour {
	public GameObject menu=null;
	public static int reloadCount=0;
	public void LoadMenue(){
		menu.SetActive (true);
	}
	public void Quit(){
		Application.Quit();
	}
	public  void Reload(){
		reloadCount++;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	public void Fadding(){
		SceneManager.LoadScene ("Fadding");
	}
	public void newGame(){
		GameOver.resetLevel();
		SceneManager.LoadScene (1);

	}
	public void MainMenue(){
		SceneManager.LoadScene (0);

	}
	public void Continue(){
		SceneManager.LoadScene (SaveLoad.LoadLevel());
	}
}

