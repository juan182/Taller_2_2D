using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MovePlayer : MonoBehaviour
{
    //Movimiento
    float horizontal;
    float vertical;
    float Speed = 4;

    //Salto
    float jumpForce = 150;
    bool Grounded;

    //Animacion
    Animator animator;

    //Posicion
    private Vector2 initialPosition;

    private Rigidbody2D rigidbodyPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //Toma las propiedades del RigidBody2D y lo guarda
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        //Registra posicion de inicio
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Toma el valor de Horizontal 
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = transform.position.y;
        Debug.Log("Valor de vertical: " + vertical);

        if (horizontal < 0)
        {
            transform.localScale = new Vector2(-2, 2);
        }else if (horizontal > 0) transform.localScale = new Vector2(2, 2);

        //Aplicar animacion
        animator.SetBool("running", horizontal != 0);

        //Condicional salto
        if(Physics2D.Raycast(transform.position, Vector2.down, 0.5f))
        {
            Grounded = true;
        }
        else Grounded = false;

        //Salto
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            Jump();
        }

        //Regresa al inicio
        if (vertical < -16.56932f)
        {
            ResetPlayerPosition();
        }
    }
    private void FixedUpdate()
    {
        //Toma la propiedad de velocidad de rigidbody y manten y constante 
        rigidbodyPlayer.velocity = new Vector2(horizontal, rigidbodyPlayer.velocity.y);
    }

    //Funcion reiniciar posicion 
    private void ResetPlayerPosition()
    {
        transform.position = initialPosition;
    }

    private void Jump()
    {
        rigidbodyPlayer.AddForce(Vector3.up * jumpForce);
    }

    //Funcion para aumentar la velocidad
    public void speedUp()
    {
        horizontal += horizontal * Speed;
    }

    //Aumentar el salto
    public void jumpHigh()
    {
        jumpForce += jumpForce + 100;
    }

    //Enconger
    public void shrinc()
    {
        transform.localScale = new Vector2(1, 1);
    }
}
