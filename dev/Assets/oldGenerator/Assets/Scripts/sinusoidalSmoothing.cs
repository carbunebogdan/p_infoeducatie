using UnityEngine;
using System.Collections;

public class sinusoidalSmoothing : MonoBehaviour {

	public GameObject galvanometer;
	public GameObject rotor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (transform.position.x,galvanometer.transform.position.z,transform.position.z);
	}
}
