using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario : MonoBehaviour
{
    public Dialogue dialogue;

    public GameObject pong;
    public GameObject snake;
    public GameObject runner;
    public GameObject space;

    public GameObject ecran;

    public List<SpriteRenderer> lstNotes = new List<SpriteRenderer>();

    public int step = 0;

    // Start is called before the first frame update
    void Start()
    {
        pong.SetActive(false);
        snake.SetActive(false);
        runner.SetActive(false);
        space.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(step > 0 && dialogue.showMsg == false)
        {
            if(step == 1 && dialogue.canShow == false)
            {
                pong.SetActive(true);
            }
            else if (step == 2)
            {
                lstNotes[0].enabled = true;
                snake.SetActive(true);
            }
            else if (step == 3)
            {
                lstNotes[1].enabled = true;
                runner.SetActive(true);
            }
            else if (step == 4)
            {
                lstNotes[2].enabled = true;
                space.SetActive(true);
            } else if (step == 5)
            {
                lstNotes[3].enabled = true;
            }
        }
    }

    public void Step1()
    {
        step = 1;
    }

    public void Step2()
    {
        pong.SetActive(false);
        step = 2;
        dialogue.HadToShow("Bien joué tu as réussi voila le premier code !");
    }
    public void Step2Bis()
    {
        pong.SetActive(false);
        step = 2;
        dialogue.HadToShow("Bzzzztt !");
    }

    public void Step3()
    {
        snake.SetActive(false);
        step = 3;
        dialogue.HadToShow("Bien joué tu as réussi voila le second code !");
    }
    public void Step3Bis()
    {
        snake.SetActive(false);
        step = 3;
        dialogue.HadToShow("Bzzzztt !");
    }
    public void Step4()
    {
        runner.SetActive(false);
        step = 4;
        dialogue.HadToShow("Bien joué tu as réussi voila l'avant dernier code ! Bonne chance pour le dernier ");
    }
    public void Step4Bis()
    {
        runner.SetActive(false);
        step = 4;
        dialogue.HadToShow("Bzzzztt !");
    }
    public void Step5()
    {
        space.SetActive(false);
        step = 5;
        dialogue.HadToShow("Vite ! Amorce le missile ! Tu as le code !");
    }
    public void Step5Bis()
    {
        space.SetActive(false);
        step = 5;
        dialogue.HadToShow("Bzzzztt !");
    }
}
