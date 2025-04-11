using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class GameControllerScene2 : MonoBehaviour
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
    public TextMeshProUGUI txtBag;

    [SerializeField]
    public TextMeshProUGUI txtCoin;

    [SerializeField]
    public TextMeshProUGUI txtSword;

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
        ShowBag();
        ShowCoin();
        ShowSword();
        ShowScore();

        //Condicion para abrir puerta
        if (GameManager.Instance.TotalValue >= 78) //Al recolectar 5 manzanas verdes
        {
            gate.SetActive(true); // Activa la llave cuando se recolectan todas las manzanas
        }

    }

    public void ShowScore()
    {
        txtScore.text = "Score: "+GameManager.Instance.Score.ToString();
    }

    public void ShowBag()
    {
        txtBag.text = GameManager.Instance.Bag.ToString();
    }

    public void ShowSword()
    {
        txtSword.text = GameManager.Instance.Sword.ToString();
    }

    public void ShowCoin()
    {
        txtCoin.text = GameManager.Instance.Coin.ToString();
    }


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
