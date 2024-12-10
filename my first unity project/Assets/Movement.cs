using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;
    private CharacterController characterController;
    float rotationspeed = 50;
    float speed = 50;
    Rigidbody rb;
    float jump;
    float notjump;
    float groundtime;
    float jumptime;
    float betweenjump;
    float jumpspeed = 50;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if up arrow is pressed, pitch up
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (movementDirection != Vector3.zero)
        {
            animator.SetBool("Moving", true);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationspeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("Moving", false);

        }
        if (characterController.isGrounded)
        {
            groundtime = Time.time;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumptime = Time.time;
        }

        if (Time.time - groundtime <= betweenjump)
            {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);

        }
    }
}
