using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundManager : MonoBehaviour {

    public static AudioClip XyliaAttack1;
    static AudioSource audio_source;

    // Use this for initialization
    void Start () {
        XyliaAttack1 = Resources.Load<AudioClip>("katana_sword2");

        audio_source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "XyliaAttack1":
                audio_source.PlayOneShot(XyliaAttack1); break;
            
        }
    }
}
