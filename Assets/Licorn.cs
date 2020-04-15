using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Licorn : MonoBehaviour
{
    public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickLicorn()
    {
        particleSystem.Play();
    }

    private void Awake()
    {
        particleSystem.Stop();
    }


}
