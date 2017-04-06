using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {
			Debug.Log("Du tryckte på E");
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			Debug.Log("Du tryckte på W");
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log("Du tryckte på A");
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			Debug.Log("Du tryckte på S");
		}
	}
}
