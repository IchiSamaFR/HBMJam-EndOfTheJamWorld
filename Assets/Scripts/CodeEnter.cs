using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeEnter : MonoBehaviour
{
    public string       code = "1234";
    public string       codeTaped;
    public InputField   showCode;


    public AudioSource audio;
    public AudioClip sound;
    public AudioClip soundFinCredit;

    bool won = false;
    bool end = true;

    public float timerBefore = 12;
    float timer;

    public Dialogue dial;

    // Start is called before the first frame update
    void Start()
    {
        audio.clip = sound;
    }

    // Update is called once per frame
    void Update()
    {
        if (won && timer + timerBefore < Time.time && end)
        {
            audio.volume = 0.2f;
            audio.clip = soundFinCredit;
            audio.Play();
            end = false;
            dial.gameObject.SetActive(true);
            dial.showCredits();
        }
    }

    public void enterCode(int val)
    {
        if(showCode.text == "Wrong")
        {
            showCode.text = "";
        }
        codeTaped += val.ToString();
        showCode.text = codeTaped;
    }
    public void validCode()
    {
        if (codeTaped == code && !won)
        {
            won = true;
            audio.Play();
            timer = Time.time;
        }
        else
        {
            showCode.text = "Wrong";
        }
    }
    public void resetCode()
    {
        codeTaped = "";
        showCode.text = codeTaped;
    }
}
