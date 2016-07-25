using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour {
	public GameObject homePanel;
	int seen=0;
	static Vector3 oldPos;

	// Use this for initialization
	void Start () {
		seen=PlayerPrefs.GetInt ("Seen");
		if (seen == 0) {
			homePanel.SetActive (true);
		}
		if (seen == 1) {
			transform.position = oldPos;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoSim(){
		oldPos = transform.position;
		int saw = 1;
		PlayerPrefs.SetInt ("Seen",saw);
		SceneManager.LoadScene ("oldGen");
	}
}
