using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMission : MonoBehaviour {

    public GameObject mission_list_menu;
    public GameObject side_mission_menu;


    public void Side_Mission_Back()
    {
        side_mission_menu.SetActive(false);
        mission_list_menu.SetActive(true);
    }
}
