using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketscript : MonoBehaviour
{
    float turningSpeed = 300;
    float thrustValue = 50;
    float gravity = 10;
    Rigidbody rb;

    Vector3 velocity, acceleration;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // acceleration = Vector3.zero;
        //acceleration += gravity * Vector3.down;
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += transform.up * Time.deltaTime * 10;
            //acceleration += thrustValue * transform.up;
            rb.AddForce(thrustValue * transform.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //if a is pressed, roll left
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //if a is pressed, roll right
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //if up arrow is pressed, pitch up
            transform.Rotate(Vector3.right, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //if up arrow is pressed, pitch up
            transform.Rotate(Vector3.left, turningSpeed * Time.deltaTime);
        }
        //roll using mouse
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime);

        transform.Rotate(Vector3.right, Input.GetAxis("Vertical") * turningSpeed * Time.deltaTime);

        // velocity += acceleration * Time.deltaTime;
        // transform.position += velocity * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
    }





}
