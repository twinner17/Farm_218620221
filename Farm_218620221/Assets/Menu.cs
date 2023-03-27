using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu: MonoBehaviour{
	//public string levelToLoad;

	public void PlayGame()
	{
		SceneManager.LoadScene ("Farm_218620221");
	}
	public void Instruc()
	{
		SceneManager.LoadScene ("INSTRUCTIONS");
	}

	public void Quit()
	{
		Debug.Log ("Quit the game?");
		Application.Quit ();
	}

}