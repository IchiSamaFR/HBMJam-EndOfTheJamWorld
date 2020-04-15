using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVaisseau : MonoBehaviour
{
    public Scenario scenario;

    public Text textCounterSpace;

    public BgSpace bgSpaceScript;

    public float indexTime;
    public float beforeTime;

    public float speedMovement;

    public float minX;
    public float maxX;

    public float secondeBeforeLauch = 4;

    public GameObject bgSpace;

    int looseNb = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        showCounter();
    }

    private void FixedUpdate()
    {
        movementPlayer();
    }

    void movementPlayer()
    {
        if (Time.time > indexTime)
        {
            indexTime = Time.time + beforeTime;

            if (transform.localPosition.x <= maxX + 0.1f && transform.localPosition.x >= minX - 0.1f)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.position = new Vector2(transform.position.x + speedMovement, transform.position.y );
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.position = new Vector2(transform.position.x + (speedMovement * -1), transform.position.y );
                }
            }

            if (transform.localPosition.x > maxX)
            {
                transform.localPosition = new Vector2(maxX, transform.localPosition.y);
            }
            else if (transform.localPosition.x < minX)
            {
                transform.localPosition = new Vector2(minX, transform.localPosition.y);
            }

        }
    }

    void showCounter()
    {
        bgSpaceScript.speedMovement = 0;
        speedMovement = 0;
        secondeBeforeLauch -= Time.deltaTime;

        textCounterSpace.text = "" + (int)secondeBeforeLauch;

        if(secondeBeforeLauch <= 0)
        {
            textCounterSpace.text = "";
            bgSpaceScript.speedMovement = 0.06f;
            speedMovement = 0.06f;
        }
    }

    void Restart()
    {
        bgSpace.transform.localPosition = new Vector2(0,0);
        secondeBeforeLauch = 4f;
        speedMovement = 0;
        this.transform.localPosition = new Vector2(0,0);
        showCounter();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "end_space")
        {
            scenario.Step5();
        }
        else
        {

            if(looseNb < 3)
            {
                looseNb++;
                Restart();
            } else
            {
                scenario.Step5Bis();
            }
        }
    }
}
