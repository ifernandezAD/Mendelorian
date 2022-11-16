using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody myRigid;

    private Vector3 inputVector;
    public float speed;

   

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal") * speed, myRigid.velocity.y, Input.GetAxis("Vertical") * speed);
        //transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

    }

    private void FixedUpdate()
    {
        myRigid.velocity = inputVector;
    }
}
