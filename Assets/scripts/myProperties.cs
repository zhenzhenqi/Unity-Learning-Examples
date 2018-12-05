using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myProperties : MonoBehaviour {
	public float myOffset;
	Rigidbody rb;
	Renderer rend;
	Color myColor;

	// Use this for initialization
	void Start () {
		myOffset = Random.Range(-10.0f, 10.0f);
		Physics.gravity = new Vector3(0, Random.Range(-1.0f, 0.0f), 0);

		rb = GetComponent<Rigidbody>();
		rb.drag = Random.Range(0.0f, 3.0f);

		rend = GetComponent<Renderer> ();
		myColor = new Color (0, 0, Random.Range (0.0f, 1.0f));
		rend.material.color = myColor;


	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
