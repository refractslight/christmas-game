using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchProjectiles : MonoBehaviour {

	//public GameObject candyCane;
	public GameObject gift1;
	/*public GameObject gift2;
	public GameObject gingerbread;
	public GameObject lights;
	public GameObject miniTree;*/
	private GameObject bullet;
	//public Button CandyCane;

	public List<GameObject> projectileList;


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
		
	}
	public void Change () {
		//bullet.gameObject = gift1.gameObject;
		GameObject bullet =  GameObject.Find("gift1");
		Debug.Log ("gift get");
	}
}
