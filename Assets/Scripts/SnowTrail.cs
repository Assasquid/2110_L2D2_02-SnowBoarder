using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowTrailFX;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            snowTrailFX.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) 
    {
         if(other.gameObject.tag == "Ground")
         {
             snowTrailFX.Stop();
         }
    }
}
