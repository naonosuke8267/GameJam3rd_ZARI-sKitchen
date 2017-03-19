using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class king : MonoBehaviour {
    public int vector_x;
    public int vector_y;
    // Use this for initialization
    void Start () {
        set();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void set()
    {
        GetComponent< Rigidbody >(). AddForce(new Vector2(vector_x, vector_y));
    }
}
