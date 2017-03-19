using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {
    public int time_end=0;
    public bool GameEnd ;
    public float Score;
    public int []m_ngchip = new int[] { 0, 1, 2 };
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
        time();
	}
    void time()
    {
        if(time_end == 1)
        {
            GameEnd = true;
        }
    }

	public void SetRandom(int ron)
    {
        if (ron==4) {
            m_ngchip[Random.Range(0, 3)] = 4;
		}else{
			m_ngchip = new int[]{0,1,2};
		}
    }

	public int[] getRandom(){
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
