using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject slime;
	float spawnRate = 2.5f;
	float nextSpawn = 0.0f;
	float randx;
	float  spawn;
	public static int cantidad;
	int maximo = 104;
	Vector2 wheretospawn;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Puntuacion.puntos < 500){
			spawn = 2.5f;
		}
		if(Puntuacion.puntos >= 500){
			spawn = 2f;
		}
		if(Puntuacion.puntos >= 1000){
			spawn = 1.5f;
		}
		if (Puntuacion.puntos >= 1500){
			spawn = 1f;
		}
		if(Puntuacion.puntos >= 2000){
			spawn = 0.5f;
		}
		if(Puntuacion.puntos >= 2500){
			spawn = 0f;
		}
		if (Time.time == 10f){
			spawnRate = spawnRate - 0.5f;
		}
		if (Time.time == 20f){
			spawnRate = spawnRate - 0.5f;
		}
		if (Time.time == 30f){
			spawnRate = spawnRate - 0.5f;
		}
		if (Time.time == 40f){
			spawnRate = spawnRate - 0.5f;
		}
		if (Time.time == 50f){
			spawnRate = spawnRate - 0.5f;
		}
		if(cantidad <= maximo){
		if(Time.time > nextSpawn && Puntuacion.existencia)
		{
			cantidad = cantidad + 1;
			nextSpawn = Time.time + spawnRate + spawn + 1;
			wheretospawn = new Vector2(transform.position.x,transform.position.y);
			Instantiate (slime,wheretospawn,Quaternion.identity);
		} 
	}
	}
}
