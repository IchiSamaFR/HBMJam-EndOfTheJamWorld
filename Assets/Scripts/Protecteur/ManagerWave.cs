using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerWave : MonoBehaviour
{
    public float timeBetweenWave;

    float indexTime = 3;

    public GameObject Wave1;
    public GameObject Wave2;

    float indexWave = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SpawnWave();

        if(indexWave == 1)
        {
            Wave1.SetActive(true);
        }else if(indexWave == 2)
        {
            Wave2.SetActive(true);
            Wave1.SetActive(false);
        }
    }


    void SpawnWave()
    {
        if(Time.time > indexTime)
        {
            indexTime += timeBetweenWave;

            indexWave++;

            //A ameliorer demande a vincent , attendre que ls cubes soient en bas oiyur les suiveants
        }
    }
}
