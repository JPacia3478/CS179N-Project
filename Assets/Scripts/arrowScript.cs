using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowScript : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            other.SendMessage("TakeArrowDamage", PlayerPrefs.GetInt("atk_Star"), SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}
