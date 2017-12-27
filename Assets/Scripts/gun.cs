using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

	public GameObject bullet;
	public GameObject origin;

	public float spawnDistance = 0.5f;
	public float shootForce = 5f;
	public float rotation = 1f;

	public bool gunEnabled = false;

	// Use this for initialization
	void Start () {
		gunEnabled = false;
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
		if (bullet.CompareTag ("gift1")) {
			gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("gift1");
		}
	}

	public void candyCanes () {
		if (bullet.CompareTag ("candycane")) {
			gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("candycane");
		}
	}
	public void off () {
		bullet = GameObject.FindGameObjectWithTag("null");
		gunEnabled = false;

	}
	public void gift2 () {
		if (bullet.CompareTag ("gift2")) {
			gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("gift2");
		}
	}
	public void gingerbread () {
		if (bullet.CompareTag ("gingerbread")) {
			gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("gingerbread");
		}
	}

	public void minitree () {
		if (bullet.CompareTag ("minitree")) {
			gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("minitree");
		}
	}

	public void santahat () {
		if (bullet.CompareTag ("santahat")) {
			gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("santahat");
		}
	}
}
