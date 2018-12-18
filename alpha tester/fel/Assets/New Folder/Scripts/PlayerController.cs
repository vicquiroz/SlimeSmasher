using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static float moveSpeed = 5f;

	private Animator anim;
	private Rigidbody2D myRigidbody;
	
	private bool PlayerMoving;
	private bool attack;
	public static bool vivo = true;
	private Vector3 lastMove;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		myRigidbody =GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		PlayerMoving = false;
		attack = false;

		if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
		{
			//ztransform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
			myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed,myRigidbody.velocity.y);
			PlayerMoving = true;
			lastMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0f,0f);	
		}	

		if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
		{
			//transform.Translate (new Vector3(0f,   Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime),0f);
			myRigidbody.velocity = new Vector2(myRigidbody.velocity.x,Input.GetAxisRaw("Vertical") * moveSpeed);
			PlayerMoving = true;
			lastMove = new Vector3(0f, Input.GetAxisRaw("Vertical"),0f);
		}
		if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f){

			myRigidbody.velocity = new Vector2(myRigidbody.velocity.x,0f);

		}
		if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f){
			myRigidbody.velocity = new Vector2(0f,myRigidbody.velocity.y);

		}
		if(Input.GetAxisRaw("Fire2") > 0.5f)
		{
			attack = true;
		}
		anim.SetFloat ("MoveX", Input.GetAxisRaw("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw("Vertical"));
		anim.SetBool("PlayerMoving", PlayerMoving);
		anim.SetBool("attack", attack);
		anim.SetFloat("LastMoveX",lastMove.x);
		anim.SetFloat("LastMoveY",lastMove.y);

	}
}
