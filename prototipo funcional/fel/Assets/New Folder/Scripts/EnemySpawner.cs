using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject slime;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;
	float randx;
	Vector2 wheretospawn;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnRate;
			randx = Random.Range(-19.0f, 35.0f);
			wheretospawn = new Vector2(randx,transform.position.y);
			Instantiate (slime,wheretospawn,Quaternion.identity);
		} 
	}
}
