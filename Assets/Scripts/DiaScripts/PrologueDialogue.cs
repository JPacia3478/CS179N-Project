using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrologueDialogue : MonoBehaviour {

    public Queue<GameObject> logList;
    public GameObject currentLog;
    public GameObject part2;

    public GameObject log1;
    public GameObject log2;
    public GameObject log3;
    public GameObject log4;
    public GameObject log5;
    public GameObject log6;
    public GameObject log7;
    public GameObject log8;
    public GameObject log9;
    public GameObject log10;
    public GameObject log11;
    public GameObject log12;
    public GameObject log13;
    public GameObject log14;
    public GameObject log15;
    public GameObject log16;
    public GameObject log17;
    public GameObject log18;
    public GameObject log19;
    public GameObject log20;
    public GameObject log21;
    public GameObject log22;
    public GameObject log23;
    public GameObject log24;
    public GameObject log25;
    public GameObject log26;
    public GameObject log27;
    public GameObject log28;
    public GameObject log29;
    public GameObject log30;
    public GameObject log31;
    public GameObject log32;
    public GameObject log33;
    public GameObject log34;
    public GameObject log35;
    public GameObject log36;
    public GameObject log37;
    public GameObject log38;
    public GameObject log39;
    public GameObject log40;
    public GameObject log41;
    public GameObject log42;
    public GameObject log43;
    public GameObject log44;
    public GameObject log45;
    public GameObject log46;
    public GameObject log47;
    public GameObject log48;
    public GameObject log49;
    public GameObject log50;
    public GameObject log51;
    public GameObject log52;
    public GameObject log53;
    public GameObject log54;
    public GameObject log55;
    public GameObject log56;
    public GameObject log57;
    public GameObject log58;
    public GameObject log59;
    public GameObject log60;
    public GameObject log61;
    public GameObject log62;
    public GameObject log63;
    public GameObject log64;
    public GameObject log65;
    public GameObject log66;
    public GameObject log67;

    // Use this for initialization
    void Start () {
        currentLog = log1;
        //logList.Enqueue(log1);
        logList = new Queue<GameObject>();
        logList.Enqueue(log2);
        logList.Enqueue(log3);
        logList.Enqueue(log4);
        logList.Enqueue(log5);
        logList.Enqueue(log6);
        logList.Enqueue(log7);
        logList.Enqueue(log8);
        logList.Enqueue(log9);
        logList.Enqueue(log10);
        logList.Enqueue(log11);
        logList.Enqueue(log12);
        logList.Enqueue(log13);
        logList.Enqueue(log14);
        logList.Enqueue(log15);
        logList.Enqueue(log16);
        logList.Enqueue(log17);
        logList.Enqueue(log18);
        logList.Enqueue(log19);
        logList.Enqueue(log20);
        logList.Enqueue(log21);
        logList.Enqueue(log22);
        logList.Enqueue(log23);
        logList.Enqueue(log24);
        logList.Enqueue(log25);
        logList.Enqueue(log26);
        logList.Enqueue(log27);
        logList.Enqueue(log28);
        logList.Enqueue(log29);
        logList.Enqueue(log30);
        logList.Enqueue(log31);
        logList.Enqueue(log32);
        logList.Enqueue(log33);
        logList.Enqueue(log34);
        logList.Enqueue(log35);
        logList.Enqueue(log36);
        logList.Enqueue(log37);
        logList.Enqueue(log38);
        logList.Enqueue(log39);
        logList.Enqueue(log40);
        logList.Enqueue(log41);
        logList.Enqueue(log42);
        logList.Enqueue(log43);
        logList.Enqueue(log44);
        logList.Enqueue(log45);
        logList.Enqueue(log46);
        logList.Enqueue(log47);
        logList.Enqueue(log48);
        logList.Enqueue(log49);
        logList.Enqueue(log50);
        logList.Enqueue(log51);
        logList.Enqueue(log52);
        logList.Enqueue(log53);
        logList.Enqueue(log54);
        logList.Enqueue(log55);
        logList.Enqueue(log56);
        logList.Enqueue(log57);
        logList.Enqueue(log58);
        logList.Enqueue(log59);
        logList.Enqueue(log60);
        logList.Enqueue(log61);
        logList.Enqueue(log62);
        logList.Enqueue(log63);
        logList.Enqueue(log64);
        logList.Enqueue(log65);
        logList.Enqueue(log66);
        logList.Enqueue(log67);
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            if(logList.Count == 0)
            {
                quitDialogue();
            }
            advance();
        }
	}

    void advance()
    {
        currentLog.SetActive(false);
        Debug.Log(currentLog);
        currentLog = logList.Dequeue();
        Debug.Log(currentLog);
        currentLog.SetActive(true);
    }

    void quitDialogue()
    {
        part2.SetActive(true);
        //SceneManager.LoadScene(1);
    }

}

