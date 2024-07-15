using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPause : MonoBehaviour
{
    public GameObject pausePanel;

    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
        Time.timeScale = 1;
        isPaused = false;
    }
}
