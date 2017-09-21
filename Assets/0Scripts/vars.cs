using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vars : MonoBehaviour {
	// Use this for initialization
	void Start () {
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.localScale = new Vector3 (3, 3, 3);
		Renderer r = cube.GetComponent<Renderer>();
		r.material = new Material(Shader.Find("Transparent/Diffuse"));
		//r.material.Color = new Color (1, 0, 0, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
