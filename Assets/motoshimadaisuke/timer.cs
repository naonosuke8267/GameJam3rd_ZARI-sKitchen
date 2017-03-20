using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    int timer_flg=0;
    public Gamemanager obj_manager;
    [SerializeField]
    private float time = 60;


    void Start()
    {
        GetComponent<Text>().text = ((int)time).ToString();
    }

    void Update()
    {
        if (Gamemanager.GameState==Gamemanager.State.Playing) {
            if (timer_flg == 0)
            {

                //1秒に1ずつ減らしていく
                time -= Time.deltaTime;
                //マイナスは表示しない
                if (time < 0)
                {

                    obj_manager.time_end = 1;

                    timer_flg = 1;
                }
                GetComponent<Text>().text = ((int)time).ToString();
            }
        }
    }
}
