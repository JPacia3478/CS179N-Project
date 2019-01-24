using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{

    public Collider2D hitbox;
    public Collider2D player;
    public int characterno;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.isTrigger != true && other.CompareTag("Enemy") && other.IsTouching(hitbox))
        {
            characterno = player.gameObject.GetComponent<MainCharacter>().characterno;
            if(characterno == 1)
            {
                other.SendMessageUpwards("gotHit", player.gameObject.GetComponent<MainCharacter>().Atk_X);
            }
            if (characterno == 2)
            {
                other.SendMessageUpwards("gotHit", player.gameObject.GetComponent<MainCharacter>().Atk_S);
            }
            if (characterno == 3)
            {
                other.SendMessageUpwards("gotHit", player.gameObject.GetComponent<MainCharacter>().Atk_R);
            }
            other.SendMessageUpwards("setDebuff", player.gameObject.GetComponent<MainCharacter>().statusno);
        }
    }
    //send damage calculation when hitbox overlaps enemy collider
    /*void Update()
    {
        if (hitbox.IsTouching(enemy))
        {
            enemy.SendMessageUpwards("gotHit", player.gameObject.GetComponent<MainCharacter>().Atk);
        }
    }*/
}