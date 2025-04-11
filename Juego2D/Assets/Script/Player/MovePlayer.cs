using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MovePlayer : MonoBehaviour
{

    // vida 
    //Conecto health con GameManager para crear persistencia
    public int Health
    {
        get { return GameManager.Instance.health; }
        set { GameManager.Instance.health = value; }
    }



    //Movimiento
    float horizontal;
    float vertical;
    float Speed = 2;

    //Salto
    float jumpForce = 215;
    bool Grounded;

    //Animacion
    Animator animator;

    //Posicion
    private Vector2 initialPosition;

    //Balas
    public GameObject bullet;
    private float lastshot;

    //Rigidbody
    private Rigidbody2D rigidbodyPlayer;

    


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
        //Debug.Log("Valor de vertical: " + vertical);

        if (horizontal < 0)
        {
            transform.localScale = new Vector3(-2, 2,0);
        }else if (horizontal > 0) transform.localScale = new Vector3(2, 2,0);

        //Aplicar animacion
        animator.SetBool("running", horizontal != 0);

        //Condicional salto
        if(Physics2D.Raycast(transform.position, Vector3.down, 0.5f))
        {
            Grounded = true;
        }
        else Grounded = false;
        if (Grounded == false)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }

        //Salto
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            Jump();
        }

        if(Input.GetKey(KeyCode.E) && Time.time > lastshot + 0.25f)
        {
            shot();
            lastshot = Time.time;
        }

        //Regresa al inicio
        if (vertical < -3.8f)
        {
            ResetPlayerPosition();
        }
    }
    private void FixedUpdate()
    {
        //Toma la propiedad de velocidad de rigidbody y manten y constante 
        rigidbodyPlayer.velocity = new Vector2(horizontal*Speed, rigidbodyPlayer.velocity.y);
    }

    public void HealUp(int healAmount)
    {
        Health += healAmount;
        Health = Mathf.Clamp(Health, 0, 5);
        GameManager.Instance.health = Health;
    }


    private void shot()
    {
        Vector3 direction;
        if (transform.localScale.x == 2)
        {
            direction = Vector3.right;
        }
        else direction = Vector3.left;

        GameObject bull = Instantiate(bullet, transform.position + direction*0.2f, Quaternion.identity);
        bull.GetComponent<BulletScript>().setDirection(direction);
    }

    //Funcion reiniciar posicion 
    public void ResetPlayerPosition()
    {
        transform.position = initialPosition;
        Health -= 1;
        if (Health == 0)
        {
            animator.SetBool("dead", true);
        }
    }

    public void Jump()
    {
        rigidbodyPlayer.AddForce(Vector3.up * jumpForce);
    }

    public void hit()
    {
        Health = Health - 1;

        if (Health == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Enemigo
        if (collision.gameObject.CompareTag("Enemie"))
        {
            // Lógica para manejar la colisión
            hit();
            Jump();
        }

        //Trampa
        if (collision.gameObject.CompareTag("Trap"))
        {
            // Lógica para manejar la colisión
            ResetPlayerPosition();
        }
    }

    #region BananaBoost
    public void SpeedBoost(float multiplier, float duration)
    {
        StartCoroutine(SpeedBoostRoutine(multiplier, duration));
    }

    private IEnumerator SpeedBoostRoutine(float multiplier, float duration)
    {
        float originalSpeed = Speed;
        Speed *= multiplier;
        yield return new WaitForSeconds(duration);
        Speed = originalSpeed;
    }
    #endregion

    #region Funciones extras
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
    #endregion
}
