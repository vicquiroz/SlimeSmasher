using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionArma : MonoBehaviour {

    public static int asesinatos = 0;
    
    public GameObject muerte;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D otros)
    {
        if (otros.gameObject.tag == "slime" && Input.GetKey("z")||otros.gameObject.tag == "gato" && Input.GetKey("z")||otros.gameObject.tag == "slimelvl1a" && Input.GetKey("z"))
        {
        	
            Destroy(otros.gameObject);
            
            Puntuacion.combo = Puntuacion.combo + 1;
            EnemySpawner.cantidad =  EnemySpawner.cantidad - 1;
            Puntuacion.puntos = Puntuacion.puntos + VidaSlime.Slime1 + Puntuacion.combo;
            asesinatos = asesinatos + 1;
            if (asesinatos == 10){

            	Puntuacion.level = Puntuacion.level + 1;
            	asesinatos = 0;

            	if (Circle.speed < 7f){
            	Circle.speed = Circle.speed + 0.25f;
            	}

            	if (PlayerController.moveSpeed < 10f){
            	PlayerController.moveSpeed = PlayerController.moveSpeed + 0.25f;
           	 }

        }
            
        }
    }
}
