using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //Movimiento
    float speed = 2;
    Vector2 direction;

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
        rb.velocity = direction*speed;
    }

    public void setDirection(Vector2 Direction)
    {
        direction = Direction;
    }    

    public void destroyBullet()
    {
        Destroy(rb);
    }
}
