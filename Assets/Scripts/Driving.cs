using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour {

	public float Speed;

	public float RotateSpeed;

	public GameObject Obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.W))
		{
			Obj.GetComponent<Rigidbody> ().velocity = transform.forward * Speed;
		}

		if (Input.GetKey (KeyCode.S))
		{
			Obj.GetComponent<Rigidbody> ().velocity = transform.forward * -Speed;
		}

		if (Input.GetKey (KeyCode.A))
		{
			transform.Rotate (0,-RotateSpeed,0);
		}

		if (Input.GetKey (KeyCode.D))
		{
			transform.Rotate (0,RotateSpeed,0);
		}
	}
}
