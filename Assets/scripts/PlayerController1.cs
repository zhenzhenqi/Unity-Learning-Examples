using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

	public float speed;
	public GameObject prefab;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "wall") {
			Vector3 pos = gameObject.transform.position;
			Debug.Log ("pos" + pos);
			Quaternion rot = gameObject.transform.rotation;
			Destroy (gameObject);  
			Instantiate (prefab, pos, rot);
		}
	}
}
