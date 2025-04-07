using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class GameControllerScene1 : MonoBehaviour
{
    private MovePlayer player;
    public TextMeshProUGUI txtHealth;

    [SerializeField]
    private TextMeshProUGUI txtGreenApple;
    public GameObject gate;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        ShowAppleGreen();
        ShowHealth();

        //Condicion para abrir puerta
        if (GameManager.Instance.appleGreenCount >= 50) //Al recolectar 5 manzanas verdes
        {
            gate.SetActive(true); // Activa la llave cuando se recolectan todas las manzanas
        }

    }

    public void ShowAppleGreen()
    {
        txtGreenApple.text = GameManager.Instance.AppleGreenCount.ToString();
    }

    public void ShowHealth()
    {
        txtHealth.text = player.Health.ToString();
    }

}
