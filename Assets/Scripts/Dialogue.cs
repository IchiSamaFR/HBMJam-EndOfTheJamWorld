using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text txtToShow;
    public Text txtCredits;
    public float timeBefore = 0.1f;
    float timeGet;
    public List<string> dialogueIntro;
    public string winSnake;
    public string loseSnake;

    string toShow;
    int Step = 0;
    public bool canShow;
    public bool showMsg;

    int otherCount = 0;
    int count = 0;
    int line = 0;

    public GameObject Screen;
    string showed = "GD / D / G : IchiSamaFR \nDev / GD : Vincent \nDev / GD : Merlin \nSound : Tom";
    public Scenario scenario;

    // Start is called before the first frame update
    void Start()
    {
        txtCredits.text = "";
        txtToShow.text = "";
        dialogueIntro.Add("- C’est la fin du monde !!!! \n " + "- La fin du quoi ?!");
        dialogueIntro.Add("- C’est la fin du monde !!!! \n " + "- La fin du quoi ?!");
        dialogueIntro.Add("- C’est la fin du monde !!!!! \n !!!!!!!!!!!!!!!!!!!!!!");
        dialogueIntro.Add("Bon ok passons ce moment… Donc c’était une journée normal quand tout à coup “Et ça fait bim bam boum...” Oups, mauvais texte !");
        dialogueIntro.Add("Ok c’est bon j’ai ! Donc les faits, il y a une météorite qui se rapproche de la terre ! Dans 10 minutes, il sera trop tard et la planète ne ...");
        dialogueIntro.Add("pourra plus être sauvée ! Il faut lancer le missile et vite, tu es sur l’ordinateur qui permet de lancer ce missile alors dépêche toi");
        dialogueIntro.Add("ET LANCE CE MISSILE !");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            HadToShow("oui");
        }
        if (showMsg)
        {
            Show(toShow);
        }
        if(canShow)
        {
            if (Step == 0)
            {
                Show(dialogueIntro);
            }
        }
        if(!canShow && !showMsg && otherCount == 0)
        {
            this.gameObject.SetActive(false);
        }

        if(otherCount != 0)
        {
            showCredits();
        }
    }
    void Show(List<string> toShow)
    {
        if (timeGet + timeBefore < Time.time)
        {
            if (count < dialogueIntro[line].Length)
            {
                timeGet = Time.time;
                txtToShow.text += dialogueIntro[line][count];
                count += 1;
            }
            else
            {

                if (Input.anyKey)
                {
                    if (dialogueIntro.Count - 1 > line)
                    {
                        txtToShow.text = "";
                        count = 0;
                        line += 1;
                    }
                    else
                    {
                        txtToShow.text = "";
                        canShow = false;
                        count = 0;
                        line = 0;
                        Step += 1;
                    }
                }
            }
        }
    }
    public void HadToShow(string msg)
    {
        showMsg = true;
        toShow = msg;
    }
    void Show(string toShow)
    {
        if (timeGet + timeBefore < Time.time)
        {
            if (count < toShow.Length)
            {
                timeGet = Time.time;
                txtToShow.text += toShow[count];
                count += 1;
            }
            else
            {

                if (Input.anyKey)
                {
                    txtToShow.text = "";
                    count = 0;
                    showMsg = false;
                }
            }
        }
    }

    public void showCredits()
    {
        this.GetComponent<Image>().enabled = false;
        Screen.SetActive(true);
        if (timeGet + timeBefore < Time.time)
        {
            if (otherCount < showed.Length)
            {
                timeGet = Time.time;
                txtCredits.text += showed[otherCount];
                otherCount += 1;
            }
        }
    }
}
