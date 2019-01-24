using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryMission : MonoBehaviour {

    public GameObject mission_list_menu;
    public GameObject story_mission_menu;
    public GameObject mission1;
    public GameObject mission2;
    public GameObject mission3;
    public GameObject mission4;
    public GameObject mission5;


    public int storyprogress;

    public void Start()
    {
        storyprogress = PlayerPrefs.GetInt("storyProgression");
        mission1.SetActive(true);
        if(storyprogress == 1)
        {
            mission2.SetActive(true);
        }
        else if (storyprogress == 2)
        {
            mission2.SetActive(true);
            mission3.SetActive(true);
        }
        else if (storyprogress == 3)
        {
            mission2.SetActive(true);
            mission3.SetActive(true);
            mission4.SetActive(true);
        }
        else if (storyprogress == 4 || storyprogress == 5)
        {
            mission2.SetActive(true);
            mission3.SetActive(true);
            mission4.SetActive(true);
            mission5.SetActive(true);
            
        }
    }

    public void Story_Mission_Back()
    {
        story_mission_menu.SetActive(false);
        mission_list_menu.SetActive(true);
    }

    public void StoryMission1()
    {
        PlayerPrefs.SetInt("MapNo", 1);
        SceneManager.LoadScene(2);
    }
    public void StoryMission2()
    {
        PlayerPrefs.SetInt("MapNo", 2);
        SceneManager.LoadScene(3);
    }
    public void StoryMission3()
    {
        PlayerPrefs.SetInt("MapNo", 3);
        SceneManager.LoadScene(4);
    }
    public void StoryMission4()
    {
        PlayerPrefs.SetInt("MapNo", 4);
        SceneManager.LoadScene(5);
    }
    public void StoryMission5()
    {
        PlayerPrefs.SetInt("MapNo", 5);
        SceneManager.LoadScene(6);
    }
}
