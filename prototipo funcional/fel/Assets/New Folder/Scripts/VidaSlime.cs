using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaSlime : MonoBehaviour 
{
	public float hp;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void dañado(float daño)
	{
		this.hp -= daño;
		if(this.hp < 0)
		{
			this.hp = 0;
			Destroy (this.gameObject);
		}
	}
}
