using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // Reference this class in the enemy scripts, and call the public methods
    // public EnemyManager enemyManager;
    // void EnemyDeath() {
    //         insert death stuff here
    //      enemyManager.EnemyDeathSound();
    // }

    AudioSource source;
    public AudioClip enemyPain;
    public AudioClip[] enemyAlert;
    public AudioClip[] enemyDeath;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void EnemyPainSound()
    {
        source.PlayOneShot(enemyPain);
    }

    public void EnemyAlertSound()
    {
        source.clip = enemyAlert[Random.Range(0, enemyAlert.Length)];
        source.PlayOneShot(source.clip);
    }

    public void EnemyDeathSound()
    {
        source.clip = enemyDeath[Random.Range(0, enemyDeath.Length)];
        source.PlayOneShot(source.clip);
    }
}
