using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int ScorePlayer;
    int ScoreEnnemy;

    public Scenario scenario;

    public Dialogue dialogue;

    public Text textScore;

    

    // Start is called before the first frame update
    void Start()
    {
        ScorePlayer = 0;
        ScoreEnnemy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        showScore();

        Status();
    }

    public void addPointPlayer()
    {
        ScorePlayer++;
    }

    public void addPointEnnemy()
    {
        ScoreEnnemy++;
    }

    void showScore()
    {
        textScore.text = "" + ScoreEnnemy + " - " + ScorePlayer;
    }

    void Status()
    {
        if(ScorePlayer >= 3)
        {
            Debug.Log("You Win");
            Win();
        }else if(ScoreEnnemy >= 3)
        {
            Debug.Log("You Lose");
            Lose();
        }
    }

    void Win()
    {

    }

    void Lose()
    {

    }
}
