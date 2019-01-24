using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject mainMenuQuestionObject;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void hubButton()
    {
        Debug.Log("loading HUB menu...");
    }

    public void mainMenuButton()
    {
        mainMenuQuestionObject.SetActive(true);
    }

    public void mainMenuYes()
    {
        Debug.Log("Yes");
    }

    public void mainMenuNo()
    {
        Debug.Log("No");
        mainMenuQuestionObject.SetActive(false);
    }
}
