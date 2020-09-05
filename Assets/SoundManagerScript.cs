using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip playerHitSound, fireLaserSound, enemyDestroyedSound;
    static AudioSource audioSource;

    void Start () {

        playerHitSound = Resources.Load<AudioClip> ("playerHit");
        fireLaserSound = Resources.Load<AudioClip> ("fireLaser");
        enemyDestroyedSound = Resources.Load<AudioClip> ("enemyDestroyed");
        audioSource = GetComponent<AudioSource> ();

    }
    
    void Update () {

    }

    public static void PlaySound (string clip){
        switch (clip)
        {
            
            case "playerHit":
                audioSource.PlayOneShot (playerHitSound);
                break;

            case "fireLaser":
                audioSource.PlayOneShot (fireLaserSound);
                break;

            case "enemyDestroyed":
                audioSource.PlayOneShot (enemyDestroyedSound);
                break;       
        }
    }
}