using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuControls : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject chooseGameScreen;
    public GameObject title;
    public Slider slider;

    public TMP_Text progressText;


    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CollectableControl.pointsCount = 0;
        Time.timeScale = 1;
    }
    public void LoadGame(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        Time.timeScale = 1;
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        title.SetActive(false);

        loadingScreen.SetActive(true);

        chooseGameScreen.SetActive(false);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;

            progressText.text = (progress * 100f).ToString() + "%";

            yield return null;
        }
    }
    
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
        CollectableControl.pointsCount = 0;
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
