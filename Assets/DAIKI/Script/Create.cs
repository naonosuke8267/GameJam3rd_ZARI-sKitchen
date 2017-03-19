using UnityEngine;
using System.Linq;
using System;

public class Create : MonoBehaviour
{

    int i;
    float x = -3, y = -1.5f;

    public GameObject[] da;

	public Gamemanager obj_manager;

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
		int[] ZARI = obj_manager.getRandom();

        int[] ZARI2 = ZARI.OrderBy(i => Guid.NewGuid()).ToArray();

        for (i = 0; i < 3; i++)
        {
			Instantiate(da[ZARI[0]], new Vector3(x,y), (Quaternion.identity));
            x += 0.5f;


        }
    }
}