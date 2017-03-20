using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrGage : MonoBehaviour
{

    double i;
    float y = 1.09f;
    int flg = 0;

	public bool flg_accept = true;
	public bool flg_complete = false;
	public float num_gageScale;

	private GameObject obj_parent;

    // Use this for initialization
    void Start()
    {
		obj_parent = transform.parent.gameObject;
        //transform.localScale = new Vector2(0.756f, y);
    }

    // Update is called once per frame
    void Update()
    {
        
		//if (flg_complete == false) {
			transform.localScale = new Vector3 (1.097f, y);
			//y -= 0.1f;
			if (flg == 1) {
				y += 0.05f;
				if (y >= 1.09) {
					flg = 0;
				}
			} else if (flg == 0) {
				y -= 0.05f;
				if (y <= 0) {
					flg = 1;
				}
			}
				
			if (Input.GetMouseButtonDown (0) && flg_accept == true) {
				num_gageScale = y;
				flg_accept = false;
				flg_complete = true;
			}
		//}

		if (flg_accept == true) {
			obj_parent.GetComponent<SpriteRenderer> ().enabled = true;
			GetComponent<SpriteRenderer> ().enabled = true;
		} else {
			obj_parent.GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<SpriteRenderer> ().enabled = false;
		}

    }

}