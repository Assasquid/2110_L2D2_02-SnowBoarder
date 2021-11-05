using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadNextDelay;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Invoke("LoadNextLevel", loadNextDelay);
        } 
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
