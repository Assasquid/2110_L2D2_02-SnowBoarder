using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay;
    [SerializeField] ParticleSystem crashFX;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashFX.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            hasCrashed = true;
            Invoke("ReloadLevel", reloadDelay);
        } 
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
