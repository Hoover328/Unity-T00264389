using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Inventory Inventory = other.GetComponent<Inventory>();

        if (Inventory != null)
        {
            Inventory.Collect();
            gameObject.SetActive(false);
        }
        if (Inventory = null)
        {
            print("Hello");
        }


    }

}

