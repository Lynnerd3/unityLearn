using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 15f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Adds inputs for vehicle movement
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves vehicle forward and horizontal
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

     }
}
