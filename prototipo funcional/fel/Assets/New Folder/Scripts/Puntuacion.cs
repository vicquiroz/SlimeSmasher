using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

    GameObject player;
	public static int puntos=100;
	float pasado;
	public string PuntajeString = "Puntaje: ";
	public string NivelString = "Nivel: ";
	public string ComboString = "+";
	public string lvlup = "Level Up";
	public string lvlsa = " ";

    public Text TextPuntaje;
    public Text Nivel;
    public Text Combo;
    public Text lvl;
    public static int level = 1;
    public static int combo = 0;
    public static Puntuacion Score;
    public static bool existencia = true;

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
		if(Time.time > pasado && puntos > 0){
			puntos = puntos - level;
			pasado = Time.time + 1f;
		}
		if (Combo != null) {

			Combo.text = ComboString + combo.ToString();

		}
		if (TextPuntaje != null) {

			TextPuntaje.text = PuntajeString + puntos.ToString();

		}
		if (Nivel != null) {

			Nivel.text = NivelString + level.ToString();

		}

		if (puntos <= 0)
		{	
			existencia = false;
		    Destroy(player,.0f);
		    puntos = 0;
		}
	}
}
