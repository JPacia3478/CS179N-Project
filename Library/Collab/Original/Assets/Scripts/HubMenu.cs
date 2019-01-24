using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubMenu : MonoBehaviour {

    public GameObject hub_menu;
    public GameObject mission_list_menu;
    public GameObject armory_menu;
    public GameObject equipment_menu;
    public GameObject control_screen;
    public GameObject save_menu;

    public void Mission_List()
    {
        hub_menu.SetActive(false);
        mission_list_menu.SetActive(true);
    }

    public void Armory()
    {
        hub_menu.SetActive(false);
        armory_menu.SetActive(true);
    }

    public void Equipment()
    {
        hub_menu.SetActive(false);
        equipment_menu.SetActive(true);
    }

    public void Controls()
    {
        hub_menu.SetActive(false);
        control_screen.SetActive(true);
    }

    public void Save()
    {
        hub_menu.SetActive(false);
        save_menu.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
