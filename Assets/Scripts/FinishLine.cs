using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadNextDelay;
    [SerializeField] ParticleSystem finishFX;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishFX.Play();
             GetComponent<AudioSource>().Play();
            Invoke("LoadNextLevel", loadNextDelay);
        } 
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
