using UnityEngine;
using System.Collections;

public class moveTank : MonoBehaviour {
	public float rotationSpeed = 8.5f;
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w"))
		{

			transform.Translate(Vector3.forward * speed);

		}

        if (Input.GetKey("s")) 
		{

			transform.Translate(-Vector3.forward * speed);

		}

		if (Input.GetKey ("a")) 
		{
			
			transform.Rotate(-Vector3.up * rotationSpeed);
			
		}

		if (Input.GetKey ("d")) 
		{
			
			transform.Rotate(Vector3.up * rotationSpeed);
			
		}
	}
}