using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mianScore : MonoBehaviour {
    public int many;
	// Use this for initialization
	void Start () {
        many = Mokomichi.num_catchZariganis[3];//ここを変える
        GetComponent<Text>().text = ((int)many).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
