using UnityEngine;
using System.Collections;

public class oscilate : MonoBehaviour {
	public float angle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (GameObject.FindGameObjectWithTag ("motor").transform.eulerAngles.x <= 360) {
			angle = GameObject.FindGameObjectWithTag ("motor").transform.eulerAngles.x;
		} else {
			angle = 360;
		}



		transform.position = new Vector3 (transform.position.x,1.5f + Mathf.Sin(angle)/3,transform.position.z);
	}
}
