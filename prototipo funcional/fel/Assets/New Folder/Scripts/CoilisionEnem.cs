using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilisionEnem : MonoBehaviour {

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

        if (collision.gameObject.tag == "arma" && Input.GetKey("z"))
        {
            restarVida();
        }
    }

    void restarPuntos()
    {
        Puntuacion.puntos = Puntuacion.puntos-Slime1;
    }

    void restarVida()
    {
        VidaSlime.hp1 = VidaSlime.hp1-arma.daño;
    }
}
