using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            other.SendMessage("TakeArrowDamage", PlayerPrefs.GetInt("atk_Star") * 2, SendMessageOptions.DontRequireReceiver);
            other.SendMessageUpwards("setDebuff", 1);
        }
    }
}
