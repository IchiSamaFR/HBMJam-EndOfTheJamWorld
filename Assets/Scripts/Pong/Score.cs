using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public MouvementBall ball;

    int echec = 0;

    public int ScorePlayer;
    public int ScoreEnnemy;

    public Scenario scenario;

    public Dialogue dialogue;

    public Text textScore;


    float timer;
    public float timeBefore = 1;
    int number = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        ScorePlayer = 0;
        ScoreEnnemy = 0;

        ball.movementX = 0;
        ball.movementY = 0;
        textScore.text = number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer + timeBefore < Time.time && number > 0)
        {
            timer = Time.time;

            ball.movementX = 0;
            ball.movementY = 0;
            textScore.text = number.ToString();
            number -= 1;
        } else if (timer + timeBefore < Time.time && number == 0)
        {
            ball.RestartBall();
            number -= 1;
        } else if (number == -1)
        {
            showScore();
        }
    }

    public void addPointPlayer()
    {
        ScorePlayer++;
        Status();
    }

    public void addPointEnnemy()
    {
        ScoreEnnemy++;
        Status();
    }

    void showScore()
    {
        textScore.text = "" + ScorePlayer + " - " + ScoreEnnemy;
    }

    void Status()
    {
        if(ScorePlayer >= 3)
        {
            Win();
        }else if(ScoreEnnemy >= 3)
        {
            Lose();
        }
    }

    void Win()
    {
        //Afficher dialogie
        scenario.Step2();
    }

    void Lose()
    {
        echec += 1;
        if(echec == 2)
        {
            scenario.Step2Bis();
        } else
        {
            ScorePlayer = 0;
            ScoreEnnemy = 0;
            number = 3;
        }
    }
}
