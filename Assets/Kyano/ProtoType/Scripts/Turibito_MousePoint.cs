using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turibito_MousePoint : MonoBehaviour {

	private float RIGHTMAXPOS = -0.8f;
	private float LEFTMAXPOS = -2.1f;

	public bool flg_active = false;

	private float spd_mouse;

	private float pos_init;

	// Use this for initialization
	void Start () {
		pos_init = gameObject.transform.localPosition.x;
	}
	
	// Update is called once per frame
	void Update () {

		if (flg_active == true) {
			GetComponent<CircleCollider2D> ().enabled = true;
		} else {
			//Debug.Log (gameObject.transform.localPosition);

			spd_mouse = Input.GetAxis("Mouse X") / 10;
			Vector3 baf_pos = new Vector3 (
				gameObject.transform.transform.localPosition.x + spd_mouse,
				gameObject.transform.transform.localPosition.y);

			if (baf_pos.x > RIGHTMAXPOS) {
				baf_pos.x = RIGHTMAXPOS;
			}
			if (baf_pos.x < LEFTMAXPOS) {
				baf_pos.x = LEFTMAXPOS;
			}

			gameObject.transform.localPosition = baf_pos;
			GetComponent<CircleCollider2D> ().enabled = false;
		}

	}
		
}
