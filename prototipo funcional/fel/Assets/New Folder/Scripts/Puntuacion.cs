using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

	public static int puntos=100;
	public string PuntajeString = "Puntaje: ";

    public Text TextPuntaje;

    public static Puntuacion Score;

    void Awake() {
        Score = this; 

             }

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (TextPuntaje != null) {

			TextPuntaje.text = PuntajeString + puntos.ToString();

		}
	}
}
