using UnityEngine;
using System.Collections;

public class HelpTrigger : MonoBehaviour {
	public GameObject panel;
	int k;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			print ("Player in "+ gameObject.name);
			if (panel.gameObject.activeSelf == false && k==0) {
				panel.gameObject.SetActive (true);
			}
		}

	}

	public void closePanel(){
		panel.gameObject.SetActive (false);
		k = 1;
	}
}
