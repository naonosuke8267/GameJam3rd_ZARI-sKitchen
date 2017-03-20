using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	int timer_flg=0;
	public Gamemanager obj_manager;
	[SerializeField]
	static public int num_score;


	void Start()
	{
		num_score = 0;
		GetComponent<Text>().text = num_score.ToString();
	}

	void Update()
	{
		num_score = obj_manager.Score;
		GetComponent<Text>().text = num_score.ToString();
	}
}
