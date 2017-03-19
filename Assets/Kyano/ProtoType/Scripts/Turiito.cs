using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turiito : MonoBehaviour {

	public Turibito_MousePoint obj_mousePos;

	private Vector3 pos_mouse;
	private Vector3 pos_me;

	public bool flg_active = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flg_active == true) {

			GetComponent<SpriteRenderer> ().enabled = true;

			pos_mouse = obj_mousePos.gameObject.transform.position;
			pos_me = gameObject.transform.position;

			float baf_distance = Mathf.Sqrt (Mathf.Pow (pos_mouse.x - pos_me.x, 2) + Mathf.Pow (pos_mouse.y - pos_me.y, 2));

			float baf_rotation = Mathf.Atan2 (pos_me.y - pos_mouse.y, pos_me.x - pos_mouse.x);
			baf_rotation = baf_rotation * 180 / Mathf.PI;

			GetComponent<SpriteRenderer> ().transform.localEulerAngles = new Vector3 (0, 0, baf_rotation - 90);
			GetComponent<SpriteRenderer> ().transform.localScale = new Vector3 (1, baf_distance * 100, 1);
		} else {
			GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}
