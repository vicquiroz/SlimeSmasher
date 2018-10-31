using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour { 
  
     public float speed = 75;
 
          Rigidbody2D rb;
          Animator anim;
	// Use this for initialization
	void Start () {
          rb=GetComponent < Rigidbody2D>();
anim=GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
 Vector2 movement=new Vector2(Input.GetAxis ("Horizontal"),Input.GetAxis ("Vertical"));

rb.AddForce (movement*Time.deltaTime*speed);

  if (Input.GetAxis("Horizontal")>0) {
     anim.SetTrigger ("Right");
     if (Input.GetButtonDown ("Fire1")) {
   
     anim.SetTrigger("Attack R");
     
    }
     
		
	}
if (Input.GetAxis("Horizontal")<0) {
     anim.SetTrigger ("Left");
      if (Input.GetButtonDown ("Fire1")) {
   
     anim.SetTrigger("Attack L");
     
    }
		
	}
if (Input.GetAxis("Vertical")>0) {
     anim.SetTrigger ("Up");
   if (Input.GetButtonDown ("Fire1")) {
   
     anim.SetTrigger("Attack U");
     
    }
    

		
	}
if (Input.GetAxis("Vertical")<0) {
     anim.SetTrigger ("Down");
   if (Input.GetButtonDown ("Fire1")) {
   
     anim.SetTrigger("AttackD");
     
    }
    }

   
   
   
      
}
}
