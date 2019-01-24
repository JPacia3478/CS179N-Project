using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneManager : MonoBehaviour {

    public GameObject currentLog;           //Current dialogue
    //public GameObject logList;

    public int index;
    public Queue<GameObject> holder;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0f;                        //Freezes game time
        holder = new Queue<GameObject>();
        for (int i = 0; i < transform.childCount; i++)              //Stores all available dialogue into a queue
        {
            //GameObject temp = transform.GetChild(i);
            holder.Enqueue(transform.GetChild(i).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (holder.Count == 0)
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
        currentLog = holder.Dequeue();
        Debug.Log(currentLog);
        currentLog.SetActive(true);
    }

    void quitDialogue()
    {
        SceneManager.LoadScene(1);
    }
}
