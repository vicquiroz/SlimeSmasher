using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

    GameObject player;
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
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (TextPuntaje != null) {

			TextPuntaje.text = PuntajeString + puntos.ToString();

		}
		if (puntos == 0)
		{
            Destroy(player,.0f);
            //player.morir();
		}
	}
}
