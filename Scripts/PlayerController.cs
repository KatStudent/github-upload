using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 16.75f;
    private float turnSpeed = 52.59F;
    private float horizontalInput;
    private float forwardInput;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        //Making the van go forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput );
        //Turning the van
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed );
       
    }
}
