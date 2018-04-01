using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveHorizontal ();
	}

	void MoveHorizontal(){
		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 3.0f;
		transform.Translate (x, 0, 0);
	}

	void Jump(){
		
	}
}

