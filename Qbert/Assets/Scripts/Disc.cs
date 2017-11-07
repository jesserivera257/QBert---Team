using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc : MonoBehaviour {

    private Animator anim;
    public GameObject player;
    public bool Ishere = false;
    public GameObject disc; 
    

    private void Start()
    {
        anim = disc.GetComponent<Animator>(); 
    }


    private void  OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player") 

        {
            Ishere = true; 

            //anim.SetBool("John", true);

            anim.SetTrigger("John");
            other.GetComponent<PlayerController>().enabled = false;
            other.transform.parent = this.transform;
            other.GetComponent<Rigidbody>().isKinematic = true;
        }
    }    

     void Update()
    {

    }

}
