using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScreenHUB : MonoBehaviour {

    public GameObject control_screen;
    public GameObject hub_menu;

    public void Control_BackHUB()
    {
        control_screen.SetActive(false);
        hub_menu.SetActive(true);
    }
}
