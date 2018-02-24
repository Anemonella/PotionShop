using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour 
{
	public void StartGame()
	{
		SceneManager.LoadScene("MainGame_Scene1_Version1");
	}

	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Game Quit");
	}
}
