using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionList : MonoBehaviour {

    public GameObject mission_list_menu;
    public GameObject hub_menu;
    public GameObject story_mission_menu;
    public GameObject side_mission_menu;
    public GameObject free_mission_menu;


    public void Mission_List_Back()
    {
        mission_list_menu.SetActive(false);
        hub_menu.SetActive(true);
    }

    public void Story_Mission()
    {
        mission_list_menu.SetActive(false);
        story_mission_menu.SetActive(true);
    }

    public void Side_Mission()
    {
        mission_list_menu.SetActive(false);
        side_mission_menu.SetActive(true);
    }

    public void Free_Mission()
    {
        mission_list_menu.SetActive(false);
        free_mission_menu.SetActive(true);
    }
}
