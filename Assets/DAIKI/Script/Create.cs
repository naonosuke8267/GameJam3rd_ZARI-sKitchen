using UnityEngine;
using System.Linq;
using System;

public class Create : MonoBehaviour
{

    int i;
    int x = -6, y = -4;

    public GameObject[] da;

    // Use this for initialization
    void Start()
    {
        createEbi();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public enum create
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

            Instantiate(da[0], new Vector3(x,y), (Quaternion.identity));
            x += 2;


        }
    }
}