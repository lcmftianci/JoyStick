using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.W)) {
			Debug.Log("print Up");
						transform.position += Vector3.up;		
				} else if (Input.GetKeyDown (KeyCode.S)) {
			Debug.Log("print Down");
			transform.position += Vector3.down;		
		}
	}
}
