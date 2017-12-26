using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchProjectiles : MonoBehaviour {

	//public GameObject candyCane;
	//public GameObject gift1;
	/*public GameObject gift2;
	public GameObject gingerbread;
	public GameObject lights;
	public GameObject miniTree;*/
	public GameObject bullet;
	//public Button CandyCane;
	public bool gunEnabled = false;
	//public List<GameObject> projectileList;
	public gun other;


	// Use this for initialization
	void Start () {
		//foreach (Transform child in transform) {
		//	projectileList.Add (child.gameObject);
		//}
		//Button btn = CandyCane.GetComponent<Button>();
		//btn.onClick.AddListener(Change);

	}
	
	// Update is called once per frame
	void Update () {
//		if (gunEnabled = true) {
//			if (Input.GetButtonDown ("Fire1")) {
//				other.shoot ();
//				Debug.Log ("shot");
//			}
//		}
	}
	public void Change () {
		//bullet.gameObject = gift1.gameObject;
		GameObject bullet =  GameObject.Find("gift1");
		Debug.Log ("gift get");

	}

//	public void Gift1 () {
//		bullet = GameObject.Find ("Gift_Box_1");
//		gunEnabled = true;
//	}
//
//	public void candyCanes () {
//		bullet = GameObject.Find ("Candy_Cane");
//		gunEnabled = true;
//	}
//	public void off () {
//		gunEnabled = false;
//	}
}
