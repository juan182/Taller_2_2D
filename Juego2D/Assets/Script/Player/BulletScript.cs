using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public AudioClip Audio;

    //Movimiento
    float speed = 2;
    Vector2 direction;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Audio);
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
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MovePlayer player = collision.collider.GetComponent<MovePlayer>();
        GruntScript Grunt = collision.collider.GetComponent<GruntScript>();
        if(player != null)
        {
            player.hit();
        }
        if(Grunt != null)
        {
            Grunt.hit();
        }
        destroyBullet();
    }
}
