using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
Rigidbody2D rb2D;
[SerializeField] float spinSpeed;
[SerializeField] float boostSpeed;
[SerializeField] float baseSpeed;
SurfaceEffector2D surfaceEffector2D;
bool canMove = true;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if(canMove)
        {
            SpinPlayer();
            RespondToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void SpinPlayer()
    {
        float spinAmount = spinSpeed * Input.GetAxis("Horizontal");
        rb2D.AddTorque(-spinAmount * Time.deltaTime);
    }

    void RespondToBoost()
    {
        if (Input.GetButton("Jump"))
        {
            surfaceEffector2D.speed = boostSpeed;
        }

        else 
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
