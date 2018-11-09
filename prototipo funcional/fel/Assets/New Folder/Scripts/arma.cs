using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour {
	public GameObject inicial1;
	public LayerMask queGolpear;
    public float rotacion=0;
    public float daño;
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

        if(Input.GetKey("z") && (this.tiempo > this.cooldown))
        {
        	transform.Rotate(new Vector2(180f, 0f));
        	this.tiempo = 0;

        } 
	}

	void atacar()
	{

		RaycastHit2D hit = Physics2D.Raycast(this.transform.position, this.transform.right, 10, queGolpear);

		GameObject tmp = Instantiate(this.inicial1) as GameObject;


		if(hit.collider.gameObject.CompareTag("slime"))
		{
			hit.collider.gameObject.SendMessage("dañado", this.daño);
		}
	}





	void rotar()
	{
		if(Input.GetKey ("right") && rotacion==0)
		{
		    transform.Rotate(new Vector2(0f, 180f));
		    rotacion=180;
		} 

		if(Input.GetKey ("up") && rotacion==0)
		{
		    transform.Rotate(new Vector2(0f, 180f));
		    rotacion=180;
		}  
		if(Input.GetKey ("left") && rotacion==180)
		{
		    transform.Rotate(new Vector2(0f, 180f));
		    rotacion=0;
		} 

		if(Input.GetKey ("down") && rotacion==180)
		{
		    transform.Rotate(new Vector2(0f, 180f));
		    rotacion=0;
		}   
	
	}
}
