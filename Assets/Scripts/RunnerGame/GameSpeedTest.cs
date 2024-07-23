using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeedTest : MonoBehaviour
{

    [Header("Speed elements")]
    public float initialSpeed = 1.0f; 
    public float speedIncreaseRate = 0.007f; 
    public float maxSpeed = 5.0f;
    public AudioSource[] audioSources;

    private float currentSpeed;

    [Header("Pause game elements")]
    public GameObject pausePanel;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = initialSpeed;
        Time.timeScale = 1;
        EndRunSequence.gameIsEnded = false;

        pausePanel.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

        if (EndRunSequence.gameIsEnded == false && !isPaused)
        {
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += speedIncreaseRate * Time.deltaTime;
                currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
                Time.timeScale = currentSpeed;
                Debug.Log("Game speed: " + currentSpeed);
                foreach (var audioSource in audioSources)
                {
                    audioSource.pitch = 1.0f;
                    Debug.Log("Audio speed: " + audioSource.pitch);
                }
            }
        }
        else if (EndRunSequence.gameIsEnded == true)
        {
            Time.timeScale = 0;
        }
    }
    private void TogglePause()
    {
        if (isPaused)
        {
            Continue();
        }
        else
        {
            Pause();
        }
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = currentSpeed;
        isPaused = false;
    }
}
