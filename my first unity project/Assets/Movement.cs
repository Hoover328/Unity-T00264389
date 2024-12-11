using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;
    private CharacterController characterController;
    float turningSpeed = 20;
    float speed = 10;
    Rigidbody rb;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude * speed);

        

     
        

        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += transform.up * Time.deltaTime * 10;
            //acceleration += thrustValue * transform.up;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //if a is pressed, roll left
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //if a is pressed, roll right
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //if up arrow is pressed, pitch up
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
       
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime);
        if (movementDirection != Vector3.zero)
        {
            animator.SetBool("Moving", true);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, turningSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Moving", false);

        }
      

        
    }
}
