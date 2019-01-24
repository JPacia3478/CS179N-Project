using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_Health : MonoBehaviour {

    public Text health;
    public GameObject enemy;

	// Update is called once per frame
	void Update () {
        Vector3 pos = Camera.main.WorldToScreenPoint(this.transform.position);
        health.transform.position = pos;
        if(enemy.gameObject.GetComponent<Enemy>().HP > 0)
            health.text = "HP  " + enemy.gameObject.GetComponent<Enemy>().HP;
        else
            health.gameObject.SetActive(false);
    }
}
