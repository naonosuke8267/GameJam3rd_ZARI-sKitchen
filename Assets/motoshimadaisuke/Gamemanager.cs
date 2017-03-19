using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {
    public int time_end;
    public bool GameEnd;
    public float Score;
    int[] zari= { 0,1,2};
    public enum type {
        small,
        normal,
        large,
        Golden
    }
    public type _Type;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void time()
    {
        if(time_end == 0)
        {
            GameEnd = true;
        }
    }
    void scene()
    {

    }
    void score(type _Type  ,int second)
    {

        switch (_Type)
        {

            case type.small:
                Score +=(500-second)+10;
                break;
            case type.normal:
                Score += (500 - second) + 10;
                break;
            case type.large:
                Score += (500 - second) + 10;
                break;
            case type.Golden:
                Score += (500 - second) + 100;
                break;
        }

        }
}
