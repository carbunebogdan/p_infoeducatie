using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {
	bool right = false;
	public bool started=false;
	JointMotor engine;
	int i=0;
	bool goes;
	public float targVel=0;
    float speed = 1.5f;
    
	void Awake(){
		Screen.lockCursor = false;
		Cursor.visible = true;
	}

    void Start(){
		engine=GameObject.FindGameObjectWithTag("motor").GetComponent<HingeJoint> ().motor;
		HingeJoint motor=GameObject.FindGameObjectWithTag("motor").GetComponent<HingeJoint> ();


	}	
	
	// Update is called once per frame
	public void FixedUpdate () {
		

		JointMotor motor=GameObject.FindGameObjectWithTag("motor").GetComponent<HingeJoint> ().motor;

		if (started == true && targVel < 1001) {
			

			targVel = GameObject.Find ("SpeedControl").GetComponent<Slider> ().value;
			engine.targetVelocity = targVel;
			GameObject.FindGameObjectWithTag ("motor").GetComponent<HingeJoint> ().motor = engine;

		}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
         if (Input.GetKey(KeyCode.LeftShift)) {
             transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
         }
         if (Input.GetKey(KeyCode.LeftControl))
         {
             transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
         }
        





    }

	public void go(){
		HingeJoint motor=GameObject.FindGameObjectWithTag("motor").GetComponent<HingeJoint> ();
		motor.useMotor = true;
		started = true;
		goes = true;

































	}
	public void stop(){
		HingeJoint motor=GameObject.FindGameObjectWithTag("motor").GetComponent<HingeJoint> ();
		//goes = false;
		motor.useMotor = false;
		//started = false;
		//velocity = motor.motor.targetVelocity;
		//velocity -= 50;

	}

	public void exit(){
		
		SceneManager.LoadScene("version1");
	}


}
