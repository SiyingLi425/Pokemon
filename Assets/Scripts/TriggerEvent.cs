using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

    public string level;
    
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("Collision");

       if (other.tag == "Player")
        {
            Application.LoadLevel(level);

            Debug.Log("this works");
            
        } 
    }

}
