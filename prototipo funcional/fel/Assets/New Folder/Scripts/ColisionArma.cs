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

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "slime" && Input.GetKey("z"))
        {
            restarVida();
        }
    }

    void restarVida()
    {
        VidaSlime.hp1 = VidaSlime.hp1-arma.daño;
    }
}
