using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilisionVerde : MonoBehaviour {

	public int Slime1 = 20;
    
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            restarPuntos();
        }

        if (collision.gameObject.tag == "slimelvl1a")
        {
            unir();
        }
    }

   



    void restarPuntos()
    {
        Puntuacion.puntos = Puntuacion.puntos-Slime1;
        Puntuacion.combo = 0;
    }

    void unir()
    {
        Destroy(collision.gameObject);
    }
}
