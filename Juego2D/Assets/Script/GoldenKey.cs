using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenKey : MonoBehaviour
{
    public string name;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Asegúrate de que tu jugador tenga la etiqueta "Player"
        {
            SceneManager.LoadScene(name); // Cambia "NombreDeTuEscena" por el nombre de la escena a la que deseas ir
        }
    }
}
