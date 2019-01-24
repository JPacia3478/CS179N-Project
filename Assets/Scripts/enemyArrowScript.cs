using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyArrowScript : MonoBehaviour
{

    public int arrowDamage;

    void OnTriggerEnter2D(Collider2D other)
    {
        arrowDamage = PlayerPrefs.GetInt("enemyArrow");
        if (!other.CompareTag("Enemy"))
        {
            other.SendMessage("TakeArrowDamage", arrowDamage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }

}
