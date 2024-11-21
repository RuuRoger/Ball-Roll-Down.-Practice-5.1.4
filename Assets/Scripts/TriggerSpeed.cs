using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpeed : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            other.GetComponent<Player>().MoreSpeed();
            print("Trigger");
        }
    }
}
