using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Invoke("ReloadLevel", reloadDelay); 
        } 
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
