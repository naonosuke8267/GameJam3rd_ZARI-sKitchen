using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour {
    public int time_end=0;
    public bool GameEnd ;
	public int Score;
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
		Score = 0;
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
	public void score(int type  ,int second)
    {

		switch (type)
        {

            case 0:
                Score += 500;
                break;
            case 1:
                Score += 300;
                break;
            case 2:
                Score += 500;
                break;
            case 3:
                Score += 2000;
                break;
        }

     }
}
