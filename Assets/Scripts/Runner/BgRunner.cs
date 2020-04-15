using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgRunner : MonoBehaviour
{
    public float indexTime;

    public float speedMovement;

    public float beforeTime;
    private float saveBeforeTime;

    public counterTimeRunner counterTimeRunner;


    // Start is called before the first frame update
    void Start()
    {
        saveBeforeTime = beforeTime;
        indexTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        this.transform.localPosition = new Vector2(-0.29f, 0);
        counterTimeRunner.secondeBeforeLauch = 4;
        counterTimeRunner.LauchCounter();

    }

    private void FixedUpdate()
    {
        movementBg();
    }

    public void movementBg()
    {
        if(Time.time > indexTime)
        {
            indexTime = Time.time + beforeTime;
            transform.position = new Vector2(transform.position.x - (speedMovement),transform.position.y);
        }
    }
}
