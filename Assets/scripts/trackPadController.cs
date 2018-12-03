using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackPadController : MonoBehaviour {
	public float speed = 0.5f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Mouse X");
		float moveVertical = Input.GetAxis ("Mouse Y");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}