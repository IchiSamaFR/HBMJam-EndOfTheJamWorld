using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSpace : MonoBehaviour
{
    public float indexTime;

    public float speedMovement;

    public float beforeTime;
    private float saveBeforeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementBgSpace();
    }

    void movementBgSpace()
    {
        if (Time.time > indexTime)
        {
            indexTime = Time.time + beforeTime;
            transform.position = new Vector2(transform.position.x, transform.position.y - (speedMovement));
        }
    }
}
