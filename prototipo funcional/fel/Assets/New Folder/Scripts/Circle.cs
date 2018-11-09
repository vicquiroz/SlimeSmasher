using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

	//Variable vision y velocidad

	public float visionRadius;
	public float speed;

// variable para guardar al jugador

	GameObject player;

   //variable para guardar la posicion inicial
	Vector3 initialPosition;

	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");

		initialPosition = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 target = initialPosition;

		//persigue al personaje
		float dist = Vector3.Distance(player.transform.position, transform.position);
		if (dist < visionRadius) target= player.transform.position;
         //velocidad dada en unity
		float fixedSpeed = speed*Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);


		
     //solo crea lineas que no se ven en el gameplay
		Debug.DrawLine(transform.position, target, Color.green);

	}
	void OnDrawGizmos(){
    
      Gizmos.color = Color.yellow;
      Gizmos.DrawWireSphere(transform.position, visionRadius) ;

	}
}
