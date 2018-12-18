using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntuacion : MonoBehaviour {

    GameObject player;
	public static int puntos=100;
	float pasado;
	float tiempo;
	public string PuntajeString = "Puntaje: ";
	public string NivelString = "Nivel: ";
	public string ComboString = "+";
	public string lvlup = "Level Up";
	public string lvlsa = " ";
	public string  tiempostr = "";
	public int c;
    public Text TextPuntaje;
    public Text tiempoll;
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
		if(Time.time > tiempo && puntos <= 0){

			tiempo=tiempo+1;
			c++;
		}
		if(Time.time > pasado && puntos > 0){
			puntos = puntos - level;
			pasado = Time.time + 1f;
		}
		if (tiempoll != null){

			tiempoll.text = tiempostr + tiempo.ToString();
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
			puntos=0;
					    Destroy(player,.0f);
		    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		}
	}
