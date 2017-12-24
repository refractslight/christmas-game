using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

	public GameObject candyCane;
	public GameObject gift1;
	public GameObject gift2;
	public GameObject gingerbread;
	public GameObject lights;
	public GameObject miniTree;
	public GameObject bullet;

	public float spawnDistance = 0.5f;
	public float shootForce = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			shoot ();
		}
	}
	public void shoot(){
		GameObject thisBullet = GameObject.Instantiate (bullet, transform.position + (transform.forward * spawnDistance), new Quaternion ());
		Rigidbody thisrb = thisBullet.GetComponent<Rigidbody> ();
		thisrb.velocity = transform.forward * shootForce;
	}

}
