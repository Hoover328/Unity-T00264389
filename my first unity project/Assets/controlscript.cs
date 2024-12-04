using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlscript : MonoBehaviour
{
    Rigidbody rb;
    float jumpforce = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpforce*Vector3.up, ForceMode.Impulse);
        }

    }
}
