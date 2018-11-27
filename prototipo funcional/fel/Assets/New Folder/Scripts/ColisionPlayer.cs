using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPlayer : MonoBehaviour {


    public int Slime1 = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "slime")
        {
            reset();
            restarPuntos();
        }
    }

    void restarPuntos()
    {
        
        Puntuacion.puntos = Puntuacion.puntos-Slime1;
    }
    void reset()
    {
      Puntuacion.combo = 0;  
    }
}
