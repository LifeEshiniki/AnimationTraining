using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychan : MonoBehaviour {

	public Animator animator;

	public unitychanControl mov;

	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren <Animator> ();
		mov = GetComponentInChildren <unitychanControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
		animator.SetFloat ("Speed", mov.speed);
		transform.position += transform.forward * mov.speed * Time.deltaTime;
		transform.rotation = Quaternion.Euler(new Vector3 (0f,mov.direction,0f));
	}
}
