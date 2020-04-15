using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementBall : MonoBehaviour
{
    public float speedMovement = 0.2f;
    private float speed;
    public float indexTime = 0.2f;


    public float timeBefore = 0.05f;
    private float saveTimeBefore;

    public float dimTimeBefore = 0.02f;

    public float limitSpeedX = 1;
    private float saveLimitSpeedX;

    public float movementX;
    public float movementY;

    public float partSupBar = -0.75f;
    public float partInfBar = 0.75f;



    // Start is called before the first frame update
    void Start()
    {
        movementX = 0;
        movementY = 0;

        indexTime = Time.time;

        speed = speedMovement;
        saveTimeBefore = timeBefore;
        saveLimitSpeedX = limitSpeedX;

    }

    private void FixedUpdate()
    {
        if (Time.time > indexTime)
        {
            indexTime += timeBefore;

            this.transform.position = new Vector3((this.transform.position.x + (movementX * speedMovement)), (this.transform.position.y + (speedMovement * movementY)), 0);
        }
    }

    public void RestartBall()
    {
        this.transform.localPosition = new Vector3(0,0,0);
        speedMovement = speed;
        movementX = 1;
        movementY = 0;
        timeBefore = saveTimeBefore;
        limitSpeedX = saveLimitSpeedX;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Bar")
        {
            if(speedMovement >= limitSpeedX)
            {
                speedMovement = limitSpeedX;
            }
            else
            {
                speedMovement += 0.01f;
                timeBefore -= dimTimeBefore;
            }

            if(collision.gameObject.transform.position.y - this.gameObject.transform.position.y <= partSupBar)
            {
                movementY = 0.5f;
            }
            else if(collision.gameObject.transform.position.y - this.gameObject.transform.position.y >= partInfBar)
            {
                movementY = -0.5f;
            }
            else
            {
                movementY = 0;
            }

            movementX *= -1;
        }
        else if(collision.transform.tag == "Wall")
        {
            movementY *= -1;
        }
    }

}
