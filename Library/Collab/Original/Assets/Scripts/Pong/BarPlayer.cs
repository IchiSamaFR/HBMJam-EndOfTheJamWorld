using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarPlayer : MonoBehaviour
{
    public float indexTime;
    public float beforeTime;

    public float speedMovement;

    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouvementPlayer();
    }

    void MouvementPlayer()
    {
        if (Time.time > indexTime)
        {
            indexTime += beforeTime;

            if(transform.localPosition.y <= maxY && transform.localPosition.y >= minY)
            {
                
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y + speedMovement);
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y + (speedMovement * -1));
                }
            }

            if(transform.localPosition.y > maxY)
            {
                transform.localPosition = new Vector2(transform.localPosition.x,maxY);
            }else if(transform.localPosition.y < minY)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, minY);
            }

        }
  
    }
}
