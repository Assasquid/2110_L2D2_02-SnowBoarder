using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
Rigidbody2D rb2D;
[SerializeField] float spinSpeed;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float spinAmount = spinSpeed * Input.GetAxis("Horizontal");
        rb2D.AddTorque(-spinAmount * Time.deltaTime);
    }
}
