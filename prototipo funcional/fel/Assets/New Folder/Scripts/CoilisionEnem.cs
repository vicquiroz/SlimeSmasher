using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilisionEnem : MonoBehaviour {

	public int Slime1 = 20;
    public GameObject slime;
	// Use this for initialization
	void Start ()
	{
		slime = GameObject.FindGameObjectWithTag("slime");
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
        
        if (collision.gameObject.tag == "slime" )
        { 
            unir();
        }
    }

    

    void restarPuntos()
    {
        Puntuacion.puntos = Puntuacion.puntos-Slime1;
    }

    void unir()
    {
    	Destroy(slime,.0f);
    }
}
