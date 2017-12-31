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
		if(gunEnabled == true) {
			if (Input.GetButtonDown ("Fire1")) {
				shoot ();
			}
		}
	}
	public void shoot () {
		if (bullet.CompareTag ("ornament")) {
			Color newColor = new Color(Random.value, Random.value, Random.value);
			GameObject thisBullet = GameObject.Instantiate (bullet, transform.position + (transform.forward * spawnDistance), new Quaternion ());
			thisBullet.GetComponent<MeshRenderer> ().material.color = newColor;
			Rigidbody thisrb = thisBullet.GetComponent<Rigidbody> ();
			thisrb.velocity = transform.forward * shootForce;
			thisrb.angularVelocity = new Vector3 (Random.value, Random.value, Random.value) * rotation;
		} 

		else {
			GameObject thisBullet = GameObject.Instantiate (bullet, transform.position + (transform.forward * spawnDistance), new Quaternion ());
			Rigidbody thisrb = thisBullet.GetComponent<Rigidbody> ();
			thisrb.velocity = transform.forward * shootForce;
			thisrb.angularVelocity = new Vector3 (Random.value, Random.value, Random.value) * rotation;
		//Debug.Log ("shoot");
		}
	}

	public void Gift1 () {
		if (bullet.CompareTag ("gift1")) {
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("gift1");
		}
		gunEnabled = true;
	}

	public void candyCanes () {
		if (bullet.CompareTag ("candycane")) {
			//gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("candycane");

		}
		gunEnabled = true;

	}
	public void off () {
			gunEnabled = false;

	}
	public void gift2 () {
		if (bullet.CompareTag ("gift2")) {
			//gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("gift2");
		}
		gunEnabled = true;
	}
	public void gingerbread () {
		if (bullet.CompareTag ("gingerbread")) {
			//gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("gingerbread");
		}
		gunEnabled = true;
	}

	public void minitree () {
		if (bullet.CompareTag ("minitree")) {
			//gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("minitree");
		}
		gunEnabled = true;
	}

	public void santahat () {
		if (bullet.CompareTag ("santahat")) {
			//gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("santahat");
		}
		gunEnabled = true;
	}

//	public void wreath () {
//		if (bullet.CompareTag ("wreath")) {
//			gunEnabled = true;
//		} 
//
//		else {
//			bullet = GameObject.FindGameObjectWithTag ("wreath");
//		}
//	}
	public void ornament () {
		if (bullet.CompareTag ("ornament")) {
			gunEnabled = true;
		} 
		else {
			bullet = GameObject.FindGameObjectWithTag ("ornament");
		}
		gunEnabled = true;
	}
}
