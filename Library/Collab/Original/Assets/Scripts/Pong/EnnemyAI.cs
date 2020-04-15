using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAI : MonoBehaviour
{
    public GameObject ball;

    public float indexTime;
    public float timeBefore;
    public float speedMovement;

    public float maxY;
    public float minY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementAI();
    }

    void MovementAI()
    {
        if(Time.time >= indexTime)
        {
            indexTime += timeBefore;


            if (transform.position.y <= maxY && transform.position.y >= minY)
            {
                if (this.transform.position.y + 0.03f < ball.transform.position.y)
                {
                    this.transform.position = new Vector2(transform.position.x, transform.position.y + (speedMovement * 1));
                }
                else if (this.transform.position.y - 0.03f > ball.transform.position.y)
                {
                    this.transform.position = new Vector2(transform.position.x, transform.position.y + (speedMovement * -1));
                }
            }

            if (transform.localPosition.y > maxY)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, maxY);
            }
            else if (transform.localPosition.y < minY)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, minY);
            }


            

        }
    }
}
