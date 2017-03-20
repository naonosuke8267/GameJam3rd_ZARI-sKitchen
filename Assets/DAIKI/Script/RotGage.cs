using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotGage : MonoBehaviour
{

    float z = 0f;
    int flg = 0;


    // Use this for initialization
    void Start()
    {
        

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
    }

}