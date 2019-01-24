using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_HitboxDefender : MonoBehaviour {

    public Collider2D enemy_hitbox;
    public Collider2D enemy_melee;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.isTrigger != true && other.CompareTag("Player") && other.IsTouching(enemy_hitbox))
        {
            other.SendMessageUpwards("gotHit", enemy_melee.gameObject.GetComponent<EnemyDefender>().Atk);
        }
    }
}
