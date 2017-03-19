using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {
    public int time_end;
    public bool GameEnd;
    public float Score;
    public int []m_ngchip = new int[] { 1, 2, 3 };
    public int ron;
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
   int[] random(int ron)
    {
       
        if (ron==4) {
            m_ngchip[Random.Range(0, 3)] = 4;
        }
        return m_ngchip;
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
