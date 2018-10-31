using UnityEngine;

using System.Collections;



public class Attack : MonoBehaviour {



public float speed = 100;

	
// Use this for initialization
	
void Start () {
	
	
}
	
	
// Update is called once per frame
	
void Update () {
		
transform.Translate (-Vector2.up * Time.deltaTime * speed);
	}
}
