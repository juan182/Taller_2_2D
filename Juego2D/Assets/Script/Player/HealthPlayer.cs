using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{

    public int maxHealth = 5;
    public int vidaActual;

    public TextMeshProUGUI vidaTexto;

    private void Start()
    {
        vidaActual = GameManager.Instance.health;
        ActualizarVida();
    }

    public void Da�o(int cantidadDa�o)
    {
        vidaActual -= cantidadDa�o;
        vidaActual = Mathf.Clamp(vidaActual, 0, maxHealth);
        GameManager.Instance.health = vidaActual;
        ActualizarVida();
        

        if (vidaActual <= 0)
        {
            Die();
        }
    }

    private void ActualizarVida()
    {
        if (vidaTexto != null)
        {
            vidaTexto.text = vidaActual.ToString();
        }
    }

    public void Health(int cantidadVida)
    {
        vidaActual += cantidadVida;
        vidaActual = Mathf.Clamp(vidaActual, 0, maxHealth);
        ActualizarVida();
    }

    

    private void Die()
    {
        Debug.Log("Jugador ha muerto.");
        // Aqu� puedes reiniciar o mostrar pantalla de muerte
    }

}
