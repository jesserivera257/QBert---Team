using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Jesse Rivera, Feature: Movement, Start:

public class JR_Movement : MonoBehaviour {


    public Transform leftCube;
    public Transform rightCube;
    public Transform topCube;
	public Transform downCube;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W))
			transform.position += rightCube.position - downCube.position;
        
		if (Input.GetKeyDown (KeyCode.D))
			transform.position += rightCube.position - topCube.position;

		if (Input.GetKeyDown (KeyCode.A))
			transform.position += leftCube.position - downCube.position;
		
		if (Input.GetKeyDown (KeyCode.S))
			transform.position += leftCube.position - topCube.position;

		if (Input.GetKeyDown (KeyCode.R))
			SceneManager.LoadScene ("QBERT");


		
	}
}
