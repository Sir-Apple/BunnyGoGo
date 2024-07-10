using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        Debug.Log("environment destroyed");
    }
}
