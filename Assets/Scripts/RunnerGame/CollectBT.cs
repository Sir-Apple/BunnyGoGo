using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBT : MonoBehaviour
{
    public AudioSource collectSFX;
    void OnTriggerEnter(Collider other)
    {
        collectSFX.Play();
        CollectableControl.pointsCount += 1;
        this.gameObject.SetActive(false);
        Debug.Log("bobatea gained");
    }
}
