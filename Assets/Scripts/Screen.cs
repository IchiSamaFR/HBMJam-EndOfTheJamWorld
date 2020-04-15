using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public SpriteRenderer taric;

    public float timeBefore = 2;
    float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            timeCount = Time.time;
        }
        if(timeCount + timeBefore < Time.time)
        {
            taric.enabled = true;
        } else
        {
            taric.enabled = false;
        }
    }
}
