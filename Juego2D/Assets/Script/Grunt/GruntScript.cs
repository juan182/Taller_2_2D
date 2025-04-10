using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    //GameObjects
    public GameObject Jhon;
    public GameObject bullet;

    //Animacion
    Animator animator;

    //Vector
    Vector2 direction;

    //Variables
    public int Health = 3;
    float distance;
    private float lastShoot;

    void Start()
    {
    }

    void Update()
    {
        direction = Jhon.transform.position - transform.position;
        if (direction.x >= 0)
        {
            transform.localScale = new Vector2(2, 2);
        } else transform.localScale = new Vector2(-2, 2);

        distance = Mathf.Abs(Jhon.transform.position.x - transform.position.x);

        if (distance < 1 && Time.time > lastShoot + 0.25)
        {
            Shoot();
            lastShoot = Time.time;
        }
    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 2)
        {
            direction = Vector2.right;
        }
        else direction = Vector2.left;

        GameObject bull = Instantiate(bullet, transform.position + direction * 0.2f, Quaternion.identity);
        bull.GetComponent<BulletScript>().setDirection(direction);
    }

    public void hit()
    {
        Health = Health - 1;

        if (Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
