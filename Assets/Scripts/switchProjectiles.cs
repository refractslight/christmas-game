using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchProjectiles : MonoBehaviour {

	public GameObject candyCane;
	public GameObject gift1;
	/*public GameObject gift2;
	public GameObject gingerbread;
	public GameObject lights;
	public GameObject miniTree;*/
	private GameObject bullet;
	public Button CandyCane;



	// Use this for initialization
	void Start () {
		
		Button btn = CandyCane.GetComponent<Button>();
		btn.onClick.AddListener(Change);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Change () {
		//bullet.gameObject = gift1.gameObject;

	}
}
