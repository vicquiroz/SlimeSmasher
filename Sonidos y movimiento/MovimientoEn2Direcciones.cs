using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class figtherController : MonoBehaviour {
	public float speed= 5f;
	public float padding =1.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Movimiento horizontal
		float hInput = Input.GetAxis("Horizontal");
	    transform.position += new Vector3(hInput*speed*Time.deltaTime,0,0);
	    //Movimiento vertical
	    float vInput = Input.GetAxis("Vertical");
	    transform.position += new Vector3(0,vInput*speed*Time.deltaTime,0);


	    //No salir de zona

	    float newX = Mathf.Clamp(transform.position.x,-10+padding,10-padding);
	    float newY = Mathf.Clamp(transform.position.y,-10+padding,10-padding);
	    transform.position= new Vector3(newX,newY,transform.position.z);

	}


}
