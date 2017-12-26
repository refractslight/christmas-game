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


	public void StartRotation(){
		isRotating = true;
	}
	public void StopRotation(){
		isRotating = false;
	}
}