using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame (){

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		Puntuacion.puntos = 100;
	}
	public void quitgame(){
		Debug.Log("QUIT");
		Application.Quit();
	}
	public void volver(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
	}
}
