using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restar : MonoBehaviour {

	public int Slime1 = 20;
	

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	}

	void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("Object Entered the trigger");
        
    }
}
