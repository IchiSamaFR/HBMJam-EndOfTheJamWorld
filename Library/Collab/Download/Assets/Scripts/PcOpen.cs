using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcOpen : MonoBehaviour
{
    public SpriteRenderer blueScreen;
    public SpriteRenderer btnTour;
    public SpriteRenderer btnScreen;
    public SpriteRenderer taric;

    public AudioSource audioSource;
    public AudioSource audioSourceVentilo;

    public float volume = 100;
    public AudioClip ambiance;
    public AudioClip startSound;

    public GameObject Pointeur;
    public Dialogue dialogue;

    bool musiqueLauch = true;


    public float timeBeforeScreen = 2;
    float timeCountScreen;

    public float timeBefore = 0.5f;
    float timeGet;

    bool open = false;
    bool cligno = false;

    void Start()
    {
        taric.gameObject.SetActive(true);
        //audioSource = this.GetComponent<AudioSource>();
        //audioSourceVentilo = this.GetComponent<AudioSource>();
    }


    void Update()
    {
        ScreenWait();

        if (open)
        {

            Pointeur.SetActive(false);
            audioSource.volume = volume / 100;
            audioSourceVentilo.volume = volume / 100;
            blueScreen.enabled = true;

            btnTour.enabled = true;
            btnScreen.enabled = true;

            if (timeGet + timeBefore < Time.time)
            {

                if (musiqueLauch)
                {
                    //audioSource.Stop();
                    audioSourceVentilo.clip = ambiance;
                    audioSourceVentilo.Play();
                    musiqueLauch = false;
                }

            }
        } else
        {
            Pointeur.SetActive(true);
            blueScreen.enabled = false;
            btnTour.enabled = false;
            btnScreen.enabled = false;
        }



    }

    public void Open()
    {
        if (!open)
        {
            timeGet = Time.time;
            open = true;
            audioSource.clip = startSound;
            audioSource.Play();

            dialogue.gameObject.SetActive(true);
            dialogue.canShow = true;
            dialogue.scenario.step = 1;
        }
    }

    void ScreenWait()
    {
        if (Input.anyKey)
        {
            timeCountScreen = Time.time;
        }

        if (timeCountScreen + timeBeforeScreen < Time.time && open)
        {
            taric.enabled = true;
        }
        else
        {
            taric.enabled = false;
        }
    }
}
