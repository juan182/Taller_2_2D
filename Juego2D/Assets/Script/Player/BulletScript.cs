using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //Movimiento
    float speed = 2;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.velocity = Vector2.right*speed;
    }
}
