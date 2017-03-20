using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score_3 : MonoBehaviour {
    public int G;
	// Use this for initialization
	void Start () {
        G = Mokomichi.num_catchZariganis[3];
        GetComponent<Text>().text = ((int)G).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
