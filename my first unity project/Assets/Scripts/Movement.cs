using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //variables for animation
    private Animator animator;
    private CharacterController characterController;
    //variables for speed
    float turningSpeed = 20;
    float speed = 2;
    Rigidbody rb;
   

    // Start is called before the first frame update
    void Start()
    {
        //rigidbody and animator components
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
            //If W is pressed, moves forwards
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //If A is pressed, moves left
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //If D is pressed, moves right
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //If S is pressed, moves down
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
       
        //Checks if character is moving
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
        //Respawns player to spawn + launches and stacks
        if (Input.GetKey(KeyCode.F5))
            transform.position = new Vector3(magnitude, 2, 1);




    }
}
