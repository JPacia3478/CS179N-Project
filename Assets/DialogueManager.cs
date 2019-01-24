using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject currentLog;           //Current dialogue
    //public GameObject logList;
    public GameObject UI_1;                 //Holds the UI for the scene
    public GameObject UI_2;

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
            Debug.Log(holder.Count);
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
        GameObject DiaCanvas = GameObject.FindGameObjectWithTag("Dialogue");
        DiaCanvas.SetActive(false);
        //currentLog.SetActive(false);
        UI_1.SetActive(true);
        UI_2.SetActive(true);
        Time.timeScale = 1f;
    }

}
