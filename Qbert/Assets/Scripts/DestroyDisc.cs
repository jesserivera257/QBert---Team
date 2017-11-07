using System.Collections;
using System.Collections.Generic;
using UnityEngine;












public class DestroyDisc : MonoBehaviour {

    public float Timer;
    public float TimerLimit = 6.0f;
    public float Timepassed;
    public GameObject disc; 

	// Use this for initialization


	void Start ()
    { 
        Timer = TimerLimit;
        Timepassed = 0.0f; 
	}
	

    void OnTriggerEnter(Collider Other)
    {

        if(Other.tag == "disc")
        {
            Debug.Log("Destroy"); 


            Timepassed += Time.deltaTime;
            if (Timepassed >= 0.0f)
            {
                Destroy(disc); 
            }

            FindObjectOfType<PlayerController>().gameObject.transform.parent = transform.root;
            FindObjectOfType<PlayerController>().GetComponent<Rigidbody>().isKinematic = false;
            FindObjectOfType<PlayerController>().enabled = true;
            transform.parent = null;
            Debug.Log("Detached"); 

        }

    }


	// Update is called once per frame
	void Update ()
    {

        Timer += Time.deltaTime; 
        if (Timer <= 0.0f)
        {
            Timer = (10);
        }

    }
}
