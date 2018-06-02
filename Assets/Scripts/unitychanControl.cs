using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychanControl : MonoBehaviour {
	
	float time;
	int Walking;

	public bool isWalking; // true-> walk ,false ->stop
	public float speed;
	public float direction;
	public float maxSpped;
	public hukidashiActive hukidashi;//のちにたくさんのオブジェクトにメッセージを送れるようにする 

	// Use this for initialization
	void Start () {
		Walking = 0;
		isWalking = false;
		direction = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		//コルーチンを使った処理に変えたい
		time += Time.deltaTime;

		if (time > 5f) {
			
			time = 0f;
			Walking = Random.Range (0,14);

			if (Walking > 7) {
				isWalking = true;
				direction = Random.Range(0f,359f);
				speed = maxSpped;
				hukidashi.SendMessage ("Hide");
			} else {
				isWalking = false;
				speed = 0f;
				hukidashi.SendMessage ("Display");
			}

		}

	}
}
