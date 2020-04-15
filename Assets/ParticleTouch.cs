using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTouch : MonoBehaviour
{
    public ParticleSystem particleSystem1;
    public ParticleSystem particleSystem2;
    public ParticleSystem particleSystem3;
    public ParticleSystem particleSystem4;
    public ParticleSystem particleSystem5;
    public ParticleSystem particleSystem6;
    public ParticleSystem particleSystem7;
    public ParticleSystem particleSystem8;
    public ParticleSystem particleSystem9;
    public ParticleSystem particleSystem10;


    // Start is called before the first frame update
    void Start()
    {
        particleSystem1.Pause();
        particleSystem2.Pause();
        particleSystem3.Pause();
        particleSystem4.Pause();
        particleSystem5.Pause();
        particleSystem6.Pause();
        particleSystem7.Pause();
        particleSystem8.Pause();
        particleSystem9.Pause();
        particleSystem10.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch(int touch)
    {
        if(touch == 1)
        {
            particleSystem1.Play();
        }else if(touch == 2)
        {
            particleSystem2.Play();
        }
        else if (touch == 3)
        {
            particleSystem3.Play();
        }
        else if (touch == 4)
        {
            particleSystem4.Play();
        }
        else if (touch == 5)
        {
            particleSystem5.Play();
        }
        else if (touch == 6)
        {
            particleSystem6.Play();
        }
        else if (touch == 7)
        {
            particleSystem7.Play();
        }
        else if (touch == 8)
        {
            particleSystem8.Play();
        }
        else if (touch == 9)
        {
            particleSystem9.Play();
        }
        else if (touch == 10)
        {
            particleSystem10.Play();
        }
    }
}
