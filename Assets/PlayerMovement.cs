using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    int speed = 1000;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    }
   
    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
      //  rb.AddForce(0,0,speed * Time.deltaTime );
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        } 
    }
}
