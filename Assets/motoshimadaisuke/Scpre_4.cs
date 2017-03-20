using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scpre_4 : MonoBehaviour {
    public int S;
	// Use this for initialization
	void Start () {
        S = Mokomichi.num_catchZariganis[0];
        GetComponent<Text>().text = ((int)S).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
