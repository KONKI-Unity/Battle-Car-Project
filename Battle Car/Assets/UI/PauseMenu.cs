using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;

	public GameObject PauseMenuUI;

	void Update(){
	
		if (Input.GetKeyDown (KeyCode.Escape)) {
		
			if (GameIsPaused) {
			
				Resume ();
			} else {
			
				Pause ();
			}
		}
	}

	public void Resume(){
		PauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause(){
		PauseMenuUI.SetActive (true);
		Time.timeScale = 1f;
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene ("Menu");
	}

	public void QuitGame(){
		Debug.Log ("Quitting game");
		Application.Quit ();
	}
}
