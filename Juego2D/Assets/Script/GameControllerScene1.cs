using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class GameControllerScene1 : MonoBehaviour
{
    [SerializeField]
    private MovePlayer player;

    [SerializeField]
    public TextMeshProUGUI txtHealth;

    [SerializeField]
    private TextMeshProUGUI txtTotalValue;

    [SerializeField]
    public GameObject gate;

    // Start is called before the first frame update
    void Start()
    {
        gate.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        ShowValeu();
        ShowHealth();

        //Condicion para abrir puerta
        if (GameManager.Instance.TotalValue >= 50) //Al recolectar 5 manzanas verdes
        {
            gate.SetActive(true); // Activa la llave cuando se recolectan todas las manzanas
        }

    }

    public void ShowValeu()
    {
        txtTotalValue.text = GameManager.Instance.TotalValue.ToString();
    }

    public void ShowHealth()
    {
        txtHealth.text = player.Health.ToString();
    }

}
