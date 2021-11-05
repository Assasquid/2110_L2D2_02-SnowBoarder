using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay;
    [SerializeField] ParticleSystem crashFX;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            crashFX.Play();
            Invoke("ReloadLevel", reloadDelay); 
        } 
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
