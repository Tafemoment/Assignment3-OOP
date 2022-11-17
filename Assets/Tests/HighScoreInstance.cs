using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreInstance
{

    public float highscoreLmao;
    public string playerLmao = "default";
   
    public HighScoreInstance(float highscore)
    {
        highscoreLmao = highscore;


    }

    public HighScoreInstance(float highscore, string player)
    {
        highscoreLmao = highscore;
        playerLmao = player;


    }

}
