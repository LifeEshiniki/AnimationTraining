﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hukidashiActive : MonoBehaviour {
	
	public unitychanControl uc;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Display(){
		canvas.SetActive (true);
	}

	void Hide(){
		canvas.SetActive (false);
	}
}
