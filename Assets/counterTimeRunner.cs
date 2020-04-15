using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterTimeRunner : MonoBehaviour
{
    public Text textTimeCount;

    public float secondeBeforeLauch;
    float saveSecondeBeforeLauch;

    public BgRunner bgRunner;

    // Start is called before the first frame update
    void Start()
    {
        bgRunner.enabled = false;
        saveSecondeBeforeLauch = secondeBeforeLauch;
    }

    // Update is called once per frame
    void Update()
    {
        LauchCounter();

        secondeBeforeLauch -= Time.deltaTime;
    }

    public void LauchCounter()
    {
        bgRunner.speedMovement = 0;
        textTimeCount.text = "" + (int)(secondeBeforeLauch);

        if(secondeBeforeLauch <= 0)
        {
            LauchGame();
            textTimeCount.text = "";
        }
    }

    void LauchGame()
    {
        bgRunner.enabled = true;
        bgRunner.speedMovement = 0.1f;
    }
}
