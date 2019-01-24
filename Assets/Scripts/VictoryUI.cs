using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryUI : MonoBehaviour {

    public int map_no;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //public void continueGame()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name); // placeholder scene name, triggers next scene
    //}

    public void quitToHUBMenu()
    {
        map_no = PlayerPrefs.GetInt("MapNo");
        if(map_no == 1)
        {
            SceneManager.LoadScene(10);
        }
        else if(map_no == 5)
        {
            SceneManager.LoadScene(11);
        }
        else
            SceneManager.LoadScene(1);
    }
}
