using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) )
        {
            transform.position += Vector3.right * Time.deltaTime * 2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * Time.deltaTime * 2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * Time.deltaTime * 2;
        }
     
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime * 2;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * Time.deltaTime * 2;
        }
      
    }
}
