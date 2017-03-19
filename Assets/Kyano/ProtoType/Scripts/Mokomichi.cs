using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mokomichi : MonoBehaviour {

	private float SPD_MAX = 2;

	public float spd_player;
	
	public Sprite[] spr_banzCatch;

	public enum MokomichiState{
		stay,		//画面外での生成待ち
		fadeIn,		//来客
		active,		//入力待ち
		fadeOut,	//怒って帰る
		catching	//バンズでキャッチ！
	}
	public enum BanzCatch{
		wait,
		small,
		nomal,
		king,
		golden,
		non
	}

	public MokomichiState enu_state;
	public BanzCatch enu_banz;

	// Use this for initialization
	void Start () {
		SetSprite (BanzCatch.wait);
	}

	void SetSprite(BanzCatch setSprite){
		GetComponent<SpriteRenderer> ().sprite = spr_banzCatch[(int)setSprite];
	}

	// Update is called once per frame
	void Update () {

		switch(enu_state){
		case MokomichiState.active:
			//初期化処理
			float baf_spdX = 0;

			//移動処理:左右キーで移動(滑る)
			if (Input.GetButton ("Horizontal")) {
				if (Input.GetAxis ("Horizontal") > 0) {
					baf_spdX = spd_player;
				} else {
					baf_spdX = -spd_player;
				}
			}

			//一定速度でリミッターをかける
			if (Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x) < SPD_MAX) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x + baf_spdX, GetComponent<Rigidbody2D> ().velocity.y);
			}

			//下キーでバンズをキャッチ、ステートを移行
			if (Input.GetButton ("Vertical") && Input.GetAxis("Vertical") < 0) {
				enu_state = MokomichiState.catching;
			}

			break;

		case MokomichiState.catching:
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);



			break;

		default:
			break;
		}

	}
}
