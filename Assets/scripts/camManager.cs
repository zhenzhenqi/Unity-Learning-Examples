using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class camManager : MonoBehaviour
{
	Rigidbody rb;
	float speed;
	//public MirrorManager MM;

	float area;
	float r;

	float x;
	float y; 
	float z;

	float theta;
	float phi;

	Quaternion originalRot;


	GameObject[] bricks; //all bricks
	GameObject target; //lookAt target


	// Use this for initialization
	void Start()
	{
		bricks = GameObject.FindGameObjectsWithTag("brick");

		Physics.gravity = new Vector3(0, Random.Range(-1.0f, 0.0f), 0);
		rb = GetComponent<Rigidbody>();
		rb.drag = Random.Range(0.0f, 3.0f);
		//area = MirrorManager.instance.matrixDiameter;
		generateRadius ();
		generateAngel ();
		updatePos ();
		findTarget();

		InvokeRepeating("findTarget", 1f, 2f);
	}

	// Update is called once per frame
	void Update()
	{
		//always look at the center cubeof cube matrix
		//target = MirrorManager.instance.centerCube;
		transform.LookAt(target.transform);

	    speed = 0.001f;
		move (speed);
		updatePos ();
	}


	public void GoForward(float value)
	{
		theta += value;
		phi += value;
	}

	public void generateAngel(){

		theta = Random.Range (-Mathf.PI, Mathf.PI);
		phi = Random.Range (-Mathf.PI, Mathf.PI);
	}

	public void generateRadius(){
		r = Random.Range(5.0f, 10.0f);
	}

	private void move(float speed){
		theta += speed;
		phi += speed;
	}

	private void updatePos(){		
		x = r * Mathf.Sin (theta) * Mathf.Cos (phi);
		y = r * Mathf.Sin (theta) * Mathf.Sin (phi);
		z = r * Mathf.Cos (theta);

		Vector3 nextPos = new Vector3(x, y, z);
		transform.position = nextPos;
	}

	private void findTarget(){
		int index = Random.Range (0, bricks.Length);
		target = bricks [index];

		generateRadius ();
		generateAngel ();
	}
}

