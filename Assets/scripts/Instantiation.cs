using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
	public GameObject brick;
	public int numberOfObjects = 20;
	public float radius = 5f;

	private GameObject[] bricks; //used to hold all bricks

	void Start() 
	{
		bricks = new GameObject[20];

		for (int i = 0; i < numberOfObjects; i++)
		{
			float angle = i * Mathf.PI * 2 / numberOfObjects;
			Vector3 pos = new Vector3(Mathf.Cos(angle), 0.1f, Mathf.Sin(angle)) * radius;
			bricks[i] = Instantiate(brick, pos, Quaternion.identity);
		}
	}
}


