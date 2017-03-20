using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotGage : MonoBehaviour
{

    float z = 0f;
    int flg = 0;

	public bool flg_accept = true;
	public bool flg_complete = false;
	public float num_gageRotation;

	private GameObject obj_parent;

    // Use this for initialization
    void Start()
    {
		obj_parent = transform.parent.gameObject;

    }

    // Update is called once per frame
    void Update()
    {



        transform.rotation = Quaternion.Euler (0,0,z);
        //y -= 0.1f;
        if (flg == 1)
        {
            z += 5f;
            if (z >= 0)
            {
                flg = 0;
            }
        }
        else if (flg == 0)
        {
            z -= 5f;
            if (z <= -90)
            {
                flg = 1;
            }
        }

		if (Input.GetMouseButtonDown (0) && flg_accept == true) {
			num_gageRotation = z;
			flg_accept = false;
			flg_complete = true;
		}

		if (flg_accept == true) {
			obj_parent.GetComponent<SpriteRenderer> ().enabled = true;
			GetComponent<SpriteRenderer> ().enabled = true;
		} else {
			obj_parent.GetComponent<SpriteRenderer> ().enabled = false;
			GetComponent<SpriteRenderer> ().enabled = false;
		}
    }

}