using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour {
	public GameObject inicial1;
	public LayerMask queGolpear;
    public float rotacion=0;
    public float cont=0;
    public static int daño=1;
    public double cooldown;
    public float tiempo;
	// Use this for initialization
	void Start () 
	{
		this.tiempo = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
        rotar();
        this.tiempo += Time.deltaTime;
        
	}

	
	void rotar()
	{
		if(Input.GetKey ("right") && rotacion!=180)
		{
			if(rotacion==270)
			{
				transform.Rotate(new Vector3(0f, 0f,-270f));
			}
			if(rotacion==90)
			{
				transform.Rotate(new Vector3(0f, 0f,-90f));
			}
		    transform.Rotate(new Vector3(0f, 180f,0f));
		    rotacion=180;
		} 

		if(Input.GetKey ("up") && rotacion!=270)
		{
			if(rotacion==180)
			{
				transform.Rotate(new Vector3(0f, -180f,0f));
			}
			if(rotacion==90)
			{
				transform.Rotate(new Vector3(0f, 0f,-90f));
			}
		    transform.Rotate(new Vector3(0f, 0f,270f));
		    rotacion=270;
		}  
		if(Input.GetKey ("left") && rotacion!=0)
		{
			if(rotacion==90)
			{
				transform.Rotate(new Vector3(0f, 0f,-90f));
			}
			if(rotacion==180)
			{
				transform.Rotate(new Vector3(0f, -180f,0f));
			}
			if(rotacion==270)
			{
				transform.Rotate(new Vector3(0f, 0f,-270f));
			}
		    rotacion=0;
		} 

		if(Input.GetKey ("down") && rotacion!=90)
		{
			if(rotacion==180)
			{
				transform.Rotate(new Vector3(0f, -180f,0f));
			}
			if(rotacion==270)
			{
				transform.Rotate(new Vector3(0f, 0f,-270f));
			}
		    transform.Rotate(new Vector3(0f, 0f,90f));
		    rotacion=90;
		}   
	
	}
}
