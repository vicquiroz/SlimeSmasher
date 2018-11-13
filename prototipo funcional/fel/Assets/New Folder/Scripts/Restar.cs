using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restar : MonoBehaviour {

	public int Slime1 = 20;
	

	void OnDestroy() {
		Puntuacion.puntos = Puntuacion.puntos-Slime1;

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
