using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaSlime : MonoBehaviour 
{
	public static int hp1 = 2;
	GameObject enemigo;

	// Use this for initialization
	void Start () 
	{
		enemigo = GameObject.FindGameObjectWithTag("slime");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(hp1 <= 0)
		{
			hp1 = 0;
			Destroy(enemigo,.0f);

		}
	}

	
}
