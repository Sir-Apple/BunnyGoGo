using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{
    public static int pointsCount;
    public GameObject pointCountDisplay;
    public GameObject pointEndDisplay;

    // Update is called once per frame
    void Update()
    {
        pointCountDisplay.GetComponent<TMP_Text>().text = "" + pointsCount.ToString();
        pointEndDisplay.GetComponent<TMP_Text>().text = "" + pointsCount.ToString();
    }
}
