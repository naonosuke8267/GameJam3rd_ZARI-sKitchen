using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mokomichi : MonoBehaviour {

	private float SPD_MAX = 2;

	public float spd_player;
	
	public Sprite[] spr_banzCatch;

	public Collision2D obj_banzCollison;
	public Gamemanager obj_manager;

	private GameObject obj_hitZarigani;

	public bool flg_banzHit;
	private bool flg_banzSwing;

	private int cnt_banzWait = 0;

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
		obj_manager.SetRandom (0);
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

			//下キーでバンズでキャッチ、ステートを移行
			if (Input.GetButton ("Vertical") && Input.GetAxis ("Vertical") < 0) {
				enu_state = MokomichiState.catching;
			}

			break;

		case MokomichiState.catching:
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			
			if (flg_banzSwing == false) {
				if (obj_hitZarigani == null) {
					SetSprite (BanzCatch.non);
				} else {
					switch (obj_hitZarigani.name) {
					case "ザリガニスモール(Clone)":
						SetSprite (BanzCatch.small);
						Destroy (obj_hitZarigani);
						obj_hitZarigani = null;
						break;
					case "マザリガニ(Clone)":
						SetSprite (BanzCatch.nomal);
						Destroy (obj_hitZarigani);
						obj_hitZarigani = null;
						break;
					case "ザリガニキング(Clone)":
						SetSprite (BanzCatch.king);
						Destroy (obj_hitZarigani);
						obj_hitZarigani = null;
						break;
					case "ザリガニゴールデン(Clone)":
						SetSprite (BanzCatch.golden);
						Destroy (obj_hitZarigani);
						obj_hitZarigani = null;
						break;
					default:
						break;//case
					}
				}
				flg_banzSwing = true;
			} else {
				cnt_banzWait++;
				if(cnt_banzWait == 30){
					flg_banzSwing = false;
					cnt_banzWait = 0;
					enu_state = MokomichiState.active;
					SetSprite (BanzCatch.wait);
					obj_manager.SetRandom (Random.Range(0,4));
				}
			}



			break;

		default:
			break;
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.tag == "ZARIGANI"){
			flg_banzHit = true;

			obj_hitZarigani = col.gameObject;
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.tag == "ZARIGANI") {
			flg_banzHit = false;

			obj_hitZarigani = null;
		}
	}
}
