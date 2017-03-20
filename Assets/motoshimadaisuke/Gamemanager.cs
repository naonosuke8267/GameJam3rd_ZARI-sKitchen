using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour {
    public int time_end=0;
    public bool GameEnd ;
    public float Score;
    public int []m_ngchip = new int[] { 0, 1, 2 };
    //public int ron;
    public enum type {
        small,
        normal,
        large,
        Golden
    }
    public enum State {
        Title,
        Playing,
        Result
    }
    public type _Type;
    static public State GameState;

    // Use this for initialization
    void Start()
    {
        
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
            Debug.Log("許さん");
            SceneManager.LoadScene("Result", LoadSceneMode.Single);
        }
    }

	public void SetRandom(int ron)
    {
		Debug.Log (ron);
        if (ron==3) {
            m_ngchip[Random.Range(0, 3)] = 3;
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
