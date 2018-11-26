using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushing : MonoBehaviour {

	public float moveSpeed;
	public float yForce;
	public float xForce;
	public float dampenForce;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Vertical") * moveSpeed;
		transform.Translate(Vector3.right * h);

		if(Input.GetKey(KeyCode.Space)){
			xForce += 5.0f;
		}

		if(Input.GetKeyUp (KeyCode.Space)){
			
		}
	}
}
