using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionArma : MonoBehaviour {

   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D otros)
    {
        if (otros.gameObject.tag == "slime" && Input.GetKey("z"))
        {
            
            Destroy(otros.gameObject);
            Puntuacion.puntos = Puntuacion.puntos + VidaSlime.Slime1;
            
        }
    }
}
