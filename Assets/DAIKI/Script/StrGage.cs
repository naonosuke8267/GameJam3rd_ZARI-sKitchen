using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrGage : MonoBehaviour
{

    double i;
    float y = 1.09f;
    int flg = 0;

    // Use this for initialization
    void Start()
    {
        //transform.localScale = new Vector2(0.756f, y);
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(0.756f, y);
        //y -= 0.1f;
        if(flg == 1)
        {
            y += 0.1f;
            if (y >= 1.09)
            {
                flg = 0;
            }
        }
        else if(flg == 0)
        {
            y -= 0.1f;
            if (y <= 0)
            {
                flg = 1;
            }
        }
    }

}