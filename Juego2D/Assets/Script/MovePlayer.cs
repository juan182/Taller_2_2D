using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    float horizontal;

    //Salto
    private float jumpForce = 150;

    private Rigidbody2D rigidbodyPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //Toma las propiedades del RigidBody2D y lo guarda
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Toma el valor de Horizontal 
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        //Toma la propiedad de velocidad de rigidbody y manten y constante 
        rigidbodyPlayer.velocity = new Vector2(horizontal, rigidbodyPlayer.velocity.y);
    }

    private void Jump()
    {
        rigidbodyPlayer.AddForce(Vector2.up * jumpForce);
    }
}
