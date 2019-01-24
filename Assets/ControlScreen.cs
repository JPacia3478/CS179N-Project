using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScreen : MonoBehaviour {

    public GameObject control_screen;
    public GameObject pause_menu;

    public void Control_Back()
    {
        control_screen.SetActive(false);
        pause_menu.SetActive(true);
    }
}
