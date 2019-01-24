using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject mainMenuQuestionObject;
    public GameObject InventoryObject;
    public GameObject ControlScreen;

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
        Time.timeScale = 1f;
        SceneManager.LoadScene("HUB_Menu");
    }

    public void mainMenuButton()
    {
        mainMenuQuestionObject.SetActive(true);
        InventoryObject.SetActive(false);
    }

    public void controlScreen()
    {
        ControlScreen.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void mainMenuYes()
    {
        //Debug.Log("Yes");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu");
    }

    public void mainMenuNo()
    {
        //Debug.Log("No");
        mainMenuQuestionObject.SetActive(false);
        InventoryObject.SetActive(true);
    }
}
