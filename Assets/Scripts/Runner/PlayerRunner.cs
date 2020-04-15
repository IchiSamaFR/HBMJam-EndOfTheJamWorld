using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunner : MonoBehaviour
{
    public Scenario scenario;
    public float speedMovement;

    public float indexTime;
    public float jumpTime;

    bool dontfly = true;

    public float timeToRejump;

    public BgRunner bgRunner;

    int looseNb = 0;

    // Start is called before the first frame update
    void Start()
    {
        indexTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        movementRunner();
    }

    void movementRunner()
    {  
        if (Input.GetKeyDown(KeyCode.Space) && dontfly)  
        {    
            transform.localPosition = new Vector2(transform.position.x,speedMovement);
            indexTime = Time.time + jumpTime;
            dontfly = false;
        }else if (Time.time > indexTime)
        {
            transform.localPosition = new Vector2(transform.position.x, 0.063f);
            if(Time.time > indexTime + timeToRejump)
            {
                dontfly = true;
            }
        }
    }

    void Restart()
    {
        bgRunner.Restart();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CubeDead")
        {
            Restart();
            if(looseNb < 5)
            {
                looseNb += 1;
            } else
            {
                scenario.Step4Bis();
            }
        }
        if(collision.tag == "end_runner")
        {
            scenario.Step4();
        }
    }
}
