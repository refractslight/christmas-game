using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

	public GameObject bullet;

	public float spawnDistance = 0.5f;
	public float shootForce = 5f;
	public float rotation = 1f;

	public bool gunEnabled = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gunEnabled = true) {
			if (Input.GetButtonDown ("Fire1")) {
				shoot ();
			}
		}
	}
	public void shoot () {
		GameObject thisBullet = GameObject.Instantiate (bullet, transform.position + (transform.forward * spawnDistance), new Quaternion ());
		Rigidbody thisrb = thisBullet.GetComponent<Rigidbody> ();
		thisrb.velocity = transform.forward * shootForce;
		thisrb.angularVelocity = new Vector3 (Random.value, Random.value, Random.value) * rotation;
	}

	public void Gift1 () {
		bullet = GameObject.Find ("Gift_Box_1");
		gunEnabled = true;
	}

	public void candyCanes () {
		bullet = GameObject.Find ("Candy_Cane");
		gunEnabled = true;
	}
	public void off () {
		gunEnabled = false;
	}
}
