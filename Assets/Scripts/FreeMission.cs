using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FreeMission : MonoBehaviour {

    public GameObject mission_list_menu;
    public GameObject free_mission_menu;
    public GameObject mission1;
    public GameObject mission2;
    public GameObject mission3;

    public int storyprogress;

    public void Start()
    {
        storyprogress = PlayerPrefs.GetInt("storyProgression");
        mission1.SetActive(true);
        if (storyprogress == 3)
        {
            mission2.SetActive(true);
        }
        else if (storyprogress == 4)
        {
            mission2.SetActive(true);
            mission3.SetActive(true);
        }
    }

    public void Free_Mission_Back()
    {
        free_mission_menu.SetActive(false);
        mission_list_menu.SetActive(true);
    }
    public void FreeMission1()
    {
        PlayerPrefs.SetInt("MapNo", 6);
        SceneManager.LoadScene(7);
    }
    public void FreeMission2()
    {
        PlayerPrefs.SetInt("MapNo", 7);
        SceneManager.LoadScene(8);
    }
    public void FreeMission3()
    {
        PlayerPrefs.SetInt("MapNo", 8);
        SceneManager.LoadScene(9);
    }
}
