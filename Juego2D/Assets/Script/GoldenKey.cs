using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenKey : MonoBehaviour
{
    public GameObject goldKey;
    public string nameScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(nameScene);
        }
    }
    void Update()
    {
        if (GameManager.Instance.appleGreenCount >= 50) // Cambia 5 por el número total de manzanas
        {
            goldKey.SetActive(true); // Activa la llave cuando se recolectan todas las manzanas
        }
    }
}
