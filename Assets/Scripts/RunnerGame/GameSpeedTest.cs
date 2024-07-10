using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedTest : MonoBehaviour
{
    public float initialSpeed = 1.0f; 
    public float speedIncreaseRate = 0.007f; 
    public float maxSpeed = 5.0f;
    //public static bool gameIsPlaying = true;

    private float currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = initialSpeed;
        Time.timeScale = 1;
        EndRunSequence.gameIsEnded = false;
        //gameIsPlaying = true;
    }
    private void Update()
    {
        if (EndRunSequence.gameIsEnded == false)
        {
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += speedIncreaseRate * Time.deltaTime;
                currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
                Time.timeScale = currentSpeed;
               // gameIsPlaying = true;
                Debug.Log(currentSpeed);
            }
        }
        else if (EndRunSequence.gameIsEnded == true)
        {
            Time.timeScale = 0;
           // gameIsPlaying = false;
        }
    }
}
