using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntermissionScript : MonoBehaviour
{
    public TextMeshProUGUI killsText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreBonusText;
    public TextMeshProUGUI treasureText;
    public TextMeshProUGUI secretsText;
    public TextMeshProUGUI timeSpentText;

    public TextMeshProUGUI timer;

    int kills;
    int score;
    int scoreBonus;
    int treasure;
    int secrets;

    float timeSpentInGame;
    int seconds;

    PlayerSettings player;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerSettings>();

        kills = player.kills;
        score = player.score;
        scoreBonus = player.scoreBonus;
        treasure = player.treasure;
        secrets = player.secrets;
        timeSpentInGame = player.timeSpentInGame;
        seconds = player.seconds;
    }

    private void Update()
    {
        timer.text = "Timer: " + player.seconds.ToString();
    }

    // this will be used on the button to update, change method to whatever you need it to be where the screen shows at the end of the scene
    public void UpdateText()
    {
        killsText.text = "Kills: " + kills.ToString();
        scoreText.text = "Score: " + score.ToString();
        scoreBonusText.text = "Score Bonus: " + scoreBonus.ToString();
        treasureText.text = "Treasure: " + treasure.ToString();
        secretsText.text = "Secrets: " + secrets.ToString();
        timeSpentText.text = "Time: " + player.seconds;
    }

    public void StartTimer()
    {
        player.timerEnabled = true;
        player.UpdateTimer();
    }

    public void StopTimer()
    {
        player.StopTimer();
    }
}
