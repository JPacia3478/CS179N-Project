using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public int enemyCount;
    public GameObject victoryUI;
    public GameObject enemyList;
    public int currentMapNo;
    public GameObject char_pos;
    public Vector3 location;

	// Use this for initialization
	void Start () {
        enemyCount = enemyList.transform.childCount / 2;
        currentMapNo = PlayerPrefs.GetInt("MapNo");
        //if (enemyCount % 2 != 0)
           // enemyCount++;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(enemyCount);
        if(currentMapNo == 1)
        {
            location = char_pos.transform.position;
            if(location.x > 222f && location.y > 60f)
            {
                victoryUI.SetActive(true);
                Time.timeScale = 0f;
                if (PlayerPrefs.GetInt("storyProgression") < 1)
                {
                    PlayerPrefs.SetInt("storyProgression", 1);
                }
            }
        }
        if (enemyCount <= 0)
        {
            Time.timeScale = 0f;
            victoryUI.SetActive(true);
        }
	}

    public void removeEnemy()
    {
        enemyCount--;
    }
}
