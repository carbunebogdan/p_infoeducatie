using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class play : MonoBehaviour {


	void Start(){
		PlayerPrefs.SetInt ("Seen", 0);

	}
	// Use this for initialization
	public void playscene(){
		SceneManager.LoadScene("version1");
	}
}
