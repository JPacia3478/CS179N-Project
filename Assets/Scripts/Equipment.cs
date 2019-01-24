using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour {

    public GameObject hub_menu;
    public GameObject equipment_menu;
    public GameObject window_Xylia;
    public GameObject window_Star;
    public GameObject window_Roc;
    public int character_window;

    private void Start()
    {
        character_window = 0;
    }

    public void Equipment_Back()
    {
        equipment_menu.SetActive(false);
        hub_menu.SetActive(true);
    }

    public void Left_Button()
    {
        if(character_window == 0)
        {
            character_window = 2;
            window_Xylia.SetActive(false);
            window_Roc.SetActive(true);
        }
        else if (character_window == 2)
        {
            character_window = 1;
            window_Roc.SetActive(false);
            window_Star.SetActive(true);
        }
        else if (character_window == 1)
        {
            character_window = 0;
            window_Star.SetActive(false);
            window_Xylia.SetActive(true);
        }
    }

    public void Right_Button()
    {
        if (character_window == 0)
        {
            character_window = 1;
            window_Xylia.SetActive(false);
            window_Star.SetActive(true);
        }
        else if (character_window == 1)
        {
            character_window = 2;
            window_Star.SetActive(false);
            window_Roc.SetActive(true);
        }
        else if (character_window == 2)
        {
            character_window = 0;
            window_Roc.SetActive(false);
            window_Xylia.SetActive(true);
        }
    }
}
