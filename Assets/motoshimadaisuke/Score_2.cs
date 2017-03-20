using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_2 : MonoBehaviour {
    public int N;
	// Use this for initialization
	void Start () {
        N = Mokomichi.num_catchZariganis[1];
        GetComponent<Text>().text = ((int)N).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
