using UnityEngine;
using System.Collections;

public class hhj : MonoBehaviour {
	public float forwardSpeed = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.forward * forwardSpeed * Time.deltaTime;
		}
	
	}
}
