using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTree : MonoBehaviour {
	public float speed = 10f;
	public bool isRotating;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isRotating){
			transform.Rotate (Vector3.up, speed * Time.deltaTime);
		}
	}

	/*public void RotateRight(){
		transform.Rotate (0, 1, 0);
	}
	public void RotateLeft(){
		transform.Rotate (0, -1, 0);

	}*/

	public void StartRotation(){
		//transform.Rotate (0, speed * Time.deltaTime, 0, Space.Self);
		//transform.Rotate(Vector3.up, speed * Time.deltaTime);
		isRotating = true;
	}
	public void StopRotation(){
		isRotating = false;
	}
}