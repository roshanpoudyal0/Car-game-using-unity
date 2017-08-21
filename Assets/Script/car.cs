using UnityEngine;
using System.Collections;

public class car : MonoBehaviour {
	public float forwardSpeed = 10.0f;
	public float backwardSpeed = 10.0f;
	public float rotateSpeed = 40.0f;
	
		void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.position -= transform.forward * forwardSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += transform.forward * backwardSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W))
		{
			
			if (Input.GetKey(KeyCode.A))
			{
				transform.Rotate( 0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
			}
			if (Input.GetKey(KeyCode.D))
			{
				transform.Rotate( 0.0f, rotateSpeed * Time.deltaTime, 0.0f);
			}
		}
		else if (Input.GetKey(KeyCode.S))
		{
			if (Input.GetKey(KeyCode.A))
			{
				transform.Rotate( 0.0f, rotateSpeed * Time.deltaTime, 0.0f);
			}
			if (Input.GetKey(KeyCode.D))
			{
				transform.Rotate( 0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
			}
		}
	}
} 