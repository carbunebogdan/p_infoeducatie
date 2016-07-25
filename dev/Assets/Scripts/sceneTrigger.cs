using UnityEngine;
using System.Collections;

public class sceneTrigger : MonoBehaviour {

	public GameObject button;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {

			button.SetActive (true);
		}
	
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {

			button.SetActive (false);
		}

	}
}
