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
        
    }

    public void Step1()
    {

        pong.SetActive(true);
    }

    public void Step2()
    {
        pong.SetActive(false);
    }

    public void Step2Bis()
    {
        snake.SetActive(true);
    }
}
