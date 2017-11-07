using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector3 jump;
    public float jumpStrength = 2.0f; 
    public float speed = 18;
    private Rigidbody rig;
    public bool isGrounded;
    



    // Use this for initialization
    void Start()
    {

        rig = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f); 
    }


    private void OnCollisionStay()
    {
        isGrounded = true; 
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rig.AddForce(jump * jumpStrength, ForceMode.Impulse);
            isGrounded = false; 
        }




        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        rig.MovePosition(transform.position + movement);


    }
}