using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;



public class HighScoreManager : MonoBehaviour
{
    private HighscoreData highscore;
    public Text bill;
    public Timer timer;
    public SaveHighscoreToFile saveSystem;

    void Start()
    {
        timer = new Timer();
        highscore = saveSystem.Load();
        bill.text = "High Score:" + highscore.score;
        GameStarted();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            saveSystem.Save(highscore);
            bill.text = "High Score" = + highscore.score;
        }
    }


    public void GameStarted()
    {
        timer.StartTimer();
    }

    public void GamesWon()
    {
        float timerScore = timer.StopTimer();
        highscore.SubmitScore(timerScore);
    }
}
