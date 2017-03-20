using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_1 : MonoBehaviour {
    public int L;
    // Use this for initialization
    void Start () {
       L= Mokomichi.num_catchZariganis[2];
        GetComponent<Text>().text = ((int)L).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
