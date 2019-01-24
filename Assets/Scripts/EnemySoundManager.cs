using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoundManager : MonoBehaviour {

    public static AudioClip enemyArcherHit, enemyArcherDeath, enemyArcherAttack, enemySwordHit, enemySwordDeath, enemySwordAttack1, enemyDeathFemale;
    static AudioSource audio_source;

	// Use this for initialization
	void Start () {
        enemyArcherHit = Resources.Load<AudioClip>("enemy_hit_sound1");
        enemyArcherDeath = Resources.Load<AudioClip>("death_sound1");
        enemyArcherAttack = Resources.Load<AudioClip>("enemy_acher_attack1");
        enemySwordHit = Resources.Load<AudioClip>("enemy_getting_hit2");
        enemySwordDeath = Resources.Load<AudioClip>("death_sound1");
        enemySwordAttack1 = Resources.Load<AudioClip>("katana_sword1");
        enemyDeathFemale = Resources.Load<AudioClip>("death_soundfemale1");

        audio_source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "enemyArcherHit":
                audio_source.PlayOneShot(enemyArcherHit); break;
            case "enemyArcherDeath":
                audio_source.PlayOneShot(enemyArcherDeath); break;
            case "enemyArcherAttack":
                audio_source.PlayOneShot(enemyArcherAttack); break;
            case "enemySwordHit":
                audio_source.PlayOneShot(enemySwordHit); break;
            case "enemySwordDeath":
                audio_source.PlayOneShot(enemySwordDeath); break;
            case "enemySwordAttack1":
                audio_source.PlayOneShot(enemySwordAttack1); break;
            case "enemyDeathFemale":
                audio_source.PlayOneShot(enemyDeathFemale); break;
        }
    }
}
