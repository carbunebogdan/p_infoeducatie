﻿using UnityEngine;
using System.Collections;

public class WalkGenerator : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		
		if(other.gameObject.tag=="Player"){
			gameObject.transform.GetChild (0).gameObject.SetActive (true);


		}

	} 

	void OnCollisionExit(Collision other){

		if(other.gameObject.tag=="Player"){
			gameObject.transform.GetChild (0).gameObject.SetActive (false);
		}

	}



}
