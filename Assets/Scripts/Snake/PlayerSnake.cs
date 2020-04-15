using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSnake : MonoBehaviour
{
    public GameObject cube;

    public float speedMovementX;
    public float speedMovementY;

    public float indexTime;
    public float beforeTime;

    public Text textCooldown;
    float timer;
    float timerBefore = 1;

    public Scenario scenario;

    List<GameObject> queues = new List<GameObject>();
    Vector2 basePos;

    bool wait = false;
    float coordX;
    float coordY;

    int looseCount;
    int number = 3;

    Vector2 orientation;


    // Start is called before the first frame update
    void Start()
    {
        indexTime = Time.time;
        basePos = this.transform.position;
        orientation.x = 1;
        orientation.y = 0;
        Restart();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer + timerBefore < Time.time && number > 0)
        {
            timer = Time.time;

            textCooldown.text = number.ToString();
            number -= 1;
        }
        else if (timer + timerBefore < Time.time && number == 0)
        {
            textCooldown.text = "";
            wait = false;
            number -= 1;
        }
        MovementPlayer();
    }

    void MovementPlayer()
    {
        if(Time.time > indexTime && !wait)
        {
            Vector2 n_pos;
            Vector2 savePos = this.transform.position;
            float x = 0;
            float y = 0;

            indexTime = Time.time + beforeTime;
            x = transform.position.x + (speedMovementX * orientation.x);
            y = transform.position.y + (speedMovementY * orientation.y);
            n_pos = new Vector2(x, y);
            this.transform.position = n_pos;

            GameObject gameobj = Instantiate(cube, savePos, Quaternion.identity);
            queues.Add(gameobj);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            orientation.x = 0;
            orientation.y = 1;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            orientation.x = 0;
            orientation.y = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            orientation.x = 1;
            orientation.y = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            orientation.x = -1;
            orientation.y = 0;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CubeDead")
        {
            Restart();
            //Tu perds
            if (looseCount <= 4)
            {
                looseCount++;
            } else
            {
                scenario.Step3Bis();
            }
            Debug.Log("You Lose!!");
        }
        else if(collision.tag == "end_snake")
        {
            Restart();
            //Tu gagnes
            orientation.x = 0;
            orientation.y = 0;
            wait = true;
            Debug.Log("You Win!!!");
            scenario.Step3();

        }
    }

    void Restart()
    {
        this.transform.position = basePos;
        orientation.x = 1;
        orientation.y = 0;
        for (int i = 0; i < queues.Count; i++)
        {
            Destroy(queues[i]);
        }
        number = 3;
        wait = true;
    }
}
