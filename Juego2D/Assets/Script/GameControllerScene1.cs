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

    //[SerializeField]
    //private TextMeshProUGUI txtTotalValue;

    [SerializeField]
    public GameObject gate;

    [SerializeField]
    public TextMeshProUGUI txtGreenApple;

    [SerializeField]
    public TextMeshProUGUI txtRedApple;

    [SerializeField]
    public TextMeshProUGUI txtStar;


    [SerializeField]
    public TextMeshProUGUI txtScore;

    // Start is called before the first frame update
    void Start()
    {
        gate.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //ShowValeu();
        ShowHealth();
        ShowGreenApple();
        ShowRedApple();
        ShowStar();

        ShowScore();

        //Condicion para abrir puerta
        if (GameManager.Instance.TotalValue >= 78) //Al recolectar manzanas
        {
            gate.SetActive(true); // Activa la llave cuando se recolectan todas las manzanas
        }

    }
    public void ShowScore()
    {
        txtScore.text = "Score: " + GameManager.Instance.Score.ToString();
    }
    //public void ShowValeu()
    //{
    //    txtTotalValue.text = GameManager.Instance.TotalValue.ToString();
    //}

    public void ShowGreenApple()
    {
        txtGreenApple.text = GameManager.Instance.GreenApple.ToString();
    }

    public void ShowRedApple()
    {
        txtRedApple.text = GameManager.Instance.RedApple.ToString();
    }

    public void ShowStar()
    {
        txtStar.text = GameManager.Instance.Star.ToString();
    }

    public void ShowHealth()
    {
        if (player != null && txtHealth != null)
        {
            txtHealth.text = player.Health.ToString();
        }
    }

}
