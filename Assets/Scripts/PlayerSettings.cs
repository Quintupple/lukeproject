using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    public bool timerEnabled;

    public int kills;
    public int score;
    public int scoreBonus;
    public int treasure;
    public int secrets;

    public float timeSpentInGame = 0.0f;
    public int seconds;

    private void Update()
    {
        UpdateTimer();
    }

    public void UpdateTimer()
    {
        if(timerEnabled)
        {
            timeSpentInGame += Time.deltaTime;
            seconds = (int)timeSpentInGame % 60;
        }
    }

    public void StopTimer()
    {
        if (timerEnabled)
            timerEnabled = false;
        timeSpentInGame = 0;
    }

    // Call this method when needing to stop timer ^^ make sure to reset between scenes
    // CALL >> seconds = 0;
}
