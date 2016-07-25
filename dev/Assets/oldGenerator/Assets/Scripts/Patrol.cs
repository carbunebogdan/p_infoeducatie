using UnityEngine;
using System.Collections;
using System.IO;

public class Patrol : MonoBehaviour {
	public Transform[] patrolPoints1;
	public Transform[] patrolPoints2 ;
	public Transform[] patrolPoints3 ;
	public Transform[] patrolPoints4 ;
	public Transform[] patrolPoints5 ;
	public float moveSpeed=35;
	float initialpos;
	float velocity;
	JointMotor engine;
	public ParticleSystem particles;
	 





	private int currentPoint;
	public float rotSpeed;

	// Use this for initialization
	void Start () {
		
		//transform.position = patrolPoints[0].position;
		initialpos=transform.position.z;
		{
			currentPoint = 0;
		}
		//HingeJoint motor=GameObject.FindGameObjectWithTag("motor").GetComponent<HingeJoint> ();
		engine=GameObject.FindGameObjectWithTag("motor").GetComponent<HingeJoint> ().motor;



	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (Time.timeScale == 1)
				Time.timeScale = 0;
			else
				Time.timeScale = 1;
		}
		rotSpeed = GameObject.FindGameObjectWithTag ("motor").GetComponent<Rigidbody> ().angularVelocity.x;

		//System.IO.File.AppendAllText ("speed.txt", "1");
		particles.startSpeed = 16-rotSpeed;
		moveSpeed = rotSpeed/5;
		if(rotSpeed>14){
			//particles.startSpeed = 1.5f;
		if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Manager>().started==true) {
			if (transform.position == patrolPoints1 [currentPoint].position) {
				currentPoint++;
			}
			if (currentPoint >= patrolPoints1.Length) {
				currentPoint = 0;
			}
		transform.position = Vector3.MoveTowards (transform.position, patrolPoints1 [currentPoint].position, moveSpeed * Time.deltaTime);
	
			}}

		if(rotSpeed>10.5f && rotSpeed<14){
			//particles.startSpeed = 2;
			if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Manager>().started==true) {
				if (transform.position == patrolPoints2 [currentPoint].position) {
					currentPoint++;
				}
				if (currentPoint >= patrolPoints2.Length) {
					currentPoint = 0;
				}
				transform.position = Vector3.MoveTowards (transform.position, patrolPoints2 [currentPoint].position, moveSpeed * Time.deltaTime);

			}} 
		if(rotSpeed >7 && rotSpeed<10.5f){
			//particles.startSpeed = 3.5f;
			if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Manager>().started==true) {
				if (transform.position == patrolPoints3 [currentPoint].position) {
					currentPoint++;
				}
				if (currentPoint >= patrolPoints3.Length) {
					currentPoint = 0;
				}
				transform.position = Vector3.MoveTowards (transform.position, patrolPoints3 [currentPoint].position, moveSpeed * Time.deltaTime);

			}} 
		if(rotSpeed >3.5f && rotSpeed<7){
			//particles.startSpeed = 5.5f;
			if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Manager>().started==true) {
				if (transform.position == patrolPoints4 [currentPoint].position) {
					currentPoint++;
				}
				if (currentPoint >= patrolPoints4.Length) {
					currentPoint = 0;
				}
				transform.position = Vector3.MoveTowards (transform.position, patrolPoints4 [currentPoint].position, moveSpeed * Time.deltaTime);

			}}    
		if(rotSpeed >0 && rotSpeed<3.5f){
			//particles.startSpeed = 7;
			if (GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Manager>().started==true) {
				if (transform.position == patrolPoints5 [currentPoint].position) {
					currentPoint++;
				}
				if (currentPoint >= patrolPoints5.Length) {
					currentPoint = 0;
				}
				transform.position = Vector3.MoveTowards (transform.position, patrolPoints5 [currentPoint].position, moveSpeed * Time.deltaTime);

			}}
		


	}

}
