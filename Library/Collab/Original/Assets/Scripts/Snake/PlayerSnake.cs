using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSnake : MonoBehaviour
{
    public GameObject cube;

    public float speedMovement;

    public float indexTime;
    public float beforeTime;

    float orientX;
    float orientY;

    float coordX;
    float coordY;

    Vector2 savePos;


    // Start is called before the first frame update
    void Start()
    {
        orientX = 1;
        orientY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }

    void MovementPlayer()
    {
        if(Time.time > indexTime)
        {
            indexTime += beforeTime;

            savePos = this.transform.position;

            this.transform.position = new Vector2(transform.position.x + (speedMovement * orientX), transform.position.y + ((speedMovement + 0.01f) * orientY));

            Instantiate(cube, savePos, Quaternion.identity);

        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            orientY = 1;
            orientX = 0;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            orientY = -1;
            orientX = 0;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            orientX = 1;
            orientY = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            orientX = -1;
            orientY = 0;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CubeDead")
        {
            //Tu perds
            Destroy(this.gameObject);
            Debug.Log("You Lose!!");

        }
        else if(collision.name == "endSnake")
        {
            //Tu gagnes
            Destroy(this.gameObject);
            Debug.Log("You Win!!!");
        }
    }
}
