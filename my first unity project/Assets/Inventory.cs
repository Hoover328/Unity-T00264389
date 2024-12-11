using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int InvNumb { get; private set; }


    public void Collect()
    {
        InvNumb++;
    }
}
