using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveBotea;
    public GameObject endScreen;
    public static bool gameIsEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence());
        gameIsEnded = false;
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        liveBotea.SetActive(false);
        endScreen.SetActive(true);
        gameIsEnded = true;
        Time.timeScale = 0;
    }
    
}
