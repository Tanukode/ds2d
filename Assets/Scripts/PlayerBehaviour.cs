using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	protected bool airborne;
	protected Rigidbody rigidBody;

	// Use this for initialization
	void OnEnable(){
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveHorizontal ();
		Jump ();
	}

	void FixedUpdate(){
	}

	void MoveHorizontal(){
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 3.0f;
		transform.Translate (x, 0, 0);
	}

	void Jump(){
		var y = Time.deltaTime * 5.0f;
		if (Input.GetKey("space")) {
			transform.Translate (0, y, 0);
		}
	}

	bool Airborne(){
		Vector3 dwn = transform.TransformDirection (Vector3.down);
		if (Physics.Raycast (transform.position, dwn, 2)) {
			return false;
		} else {
			return true;
		}

	}

}

