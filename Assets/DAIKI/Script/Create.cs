using UnityEngine;
using System.Linq;
using System;

public class Create : MonoBehaviour
{

    int i;
    float x = -3, y = -1.5f;
     AudioSource fish;
    public AudioClip fish_S;
    public GameObject[] da;
	public Sprite[] spr_state;

	public Gamemanager obj_manager;
	public Turibito_MousePoint obj_mousePos;
	public Turiito obj_turiito;
	public StrGage obj_gage;
	public RotGage obj_rotGage;

	private int cnt_fishingWait = 0;
	public bool flg_fishingClick = false;


    public enum create
    {
        createEbi,
        position,
        angle,
        momentum,
        fishing
    }
	private create enu_create;

	// Use this for initialization
	void Start()
	{
        fish = gameObject.GetComponent<AudioSource>();
        fish.clip=fish_S;
       enu_create = create.createEbi;
	}

	// Update is called once per frame
	void Update()
	{
		switch (enu_create) {
		case create.createEbi:
			x = -3;
			y = -1.7f;

			obj_mousePos.flg_active = false;
			obj_turiito.flg_active = true;

			GetComponent<SpriteRenderer> ().sprite = spr_state [0];

			int[] ZARI = obj_manager.getRandom ();
			int[] ZARI2 = ZARI.OrderBy (i => Guid.NewGuid ()).ToArray ();
		
			for (i = 0; i < 3; i++) {
				Instantiate (da [ZARI2 [i]], new Vector3 (x, y), (Quaternion.identity));
				x += 0.5f;
				if (ZARI2 [i] == 3) {
					obj_manager.SetRandom (0);
				}
			}
			//cnt_momentum = 0;
			enu_create = create.momentum;
			break;
		
		case create.momentum:
			
			if (Input.GetMouseButtonDown (0)) {
				obj_gage.flg_accept = true;
				obj_mousePos.flg_active = true;
				enu_create = create.angle;
			}
			break;

		case create.angle:
			if (Input.GetMouseButtonDown (0)) {
				obj_rotGage.flg_accept = true;
				enu_create = create.fishing;
			}

			break;

		case create.fishing:

			if (Input.GetMouseButtonDown (0)) {
				obj_mousePos.flg_fishing = true;
                fish.Play();
                obj_mousePos.flg_active = true;
				obj_turiito.flg_active = false;
				GetComponent<SpriteRenderer> ().sprite = spr_state [1];
				flg_fishingClick = true;
                   
			}

			if (flg_fishingClick == true) {
				cnt_fishingWait++;
                    
                if (cnt_fishingWait == 4) {
					obj_mousePos.flg_active = false;
				}else if (cnt_fishingWait == 30) {
					cnt_fishingWait = 0;
					flg_fishingClick = false;
					enu_create = create.createEbi;
				}
			}
             
			break;
		}
	}
}