using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Environment"))
        {
            Destroy(collision.gameObject);
            Debug.Log("environment destroyed");
        }
    }
}
