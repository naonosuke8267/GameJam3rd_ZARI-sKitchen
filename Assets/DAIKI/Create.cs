using UnityEngine;
using System.Linq;
using System;

public class Create : MonoBehaviour
{

    int i;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = 3;
        float y = -2;

        Vector2 Place = new Vector2(x, y).normalized;
    }

    enum create
    {
        createEbi,
        position,
        angle,
        momentum,
        fishing
    }

    void createEbi()
    {
        int[] ZARI = new int[] { 0, 1, 2 };

        int[] ZARI2 = ZARI.OrderBy(i => Guid.NewGuid()).ToArray();

        for (i = 0; i < 3; i++)
        {
            //switch()
            // {

            //}
        }
    }
}