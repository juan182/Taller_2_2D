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
    private TextMeshProUGUI txtGreenApple;

    [SerializeField]
    public GameObject gate;

    [SerializeField]
    public TextMeshProUGUI txtRedApple;

    [SerializeField]
    public TextMeshProUGUI txtStar;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        ShowAppleGreen();
        ShowAppleRed();
        ShowHealth();
        ShowStar();

        //Condicion para abrir puerta
        if (GameManager.Instance.appleGreenCount >= 10) //Al recolectar 5 manzanas verdes
        {
            gate.SetActive(true); // Activa la llave cuando se recolectan todas las manzanas
        }
        else
        {
            gate.SetActive(false);
        }

    }

    public void ShowStar()
    {
        
    }
    

    public void ShowAppleGreen()
    {
        txtGreenApple.text = GameManager.Instance.AppleGreenCount.ToString();
    }

    public void ShowAppleRed()
    {
        txtRedApple.text = GameManager.Instance.AppleRedCount.ToString();
    }

    public void ShowHealth()
    {
        txtHealth.text = player.Health.ToString();
    }

}
