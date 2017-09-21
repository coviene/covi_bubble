using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	public float speed;
	private Vector3 mov1;
	private float x;
	private float z;
	// Use this for initialization
	void Start () {
		mov1 = new Vector3 (0, 0, 0);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		x = Input.GetAxis ("Horizontal");
		z = Input.GetAxis ("Vertical");
		mov1.Set (x, 0, z);
		transform.Translate(mov1*speed*Time.deltaTime);
	}
}
