using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class king : MonoBehaviour {
    public int vector_x;
    public int vector_y;
	public int num_heavy;

	private int cnt_destroy = 0;
	private bool flg_destroy = false;

	public Create obj_turibito;
    // Use this for initialization
    void Start () {
		obj_turibito = FindObjectOfType<Create> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (obj_turibito.flg_fishingClick == true) {
			flg_destroy = true;
		}
		if(flg_destroy == true){
			cnt_destroy++;
			if ((cnt_destroy == 5 && GetComponent<Rigidbody2D> ().gravityScale == 0) || gameObject.transform.localPosition.y < -100) {
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.tag == "TURIITO"){
			GetComponent<Rigidbody2D> ().gravityScale = 1;
			GetComponent<Rigidbody2D>(). AddForce(new Vector2(vector_x + num_heavy / 4, vector_y - (num_heavy * 2)));
		}
	}
}
