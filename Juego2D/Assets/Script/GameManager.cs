using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    
    //Recolectables Escena 1
    private int greenApple = 0;
    private int redApple = 0;
    private int star = 0;
    private int goldenKey = 0;

    //Recolectables Escena 2
    private int bag = 0;
    private int sword = 0;
    private int coin = 0;

    public int health = 5;

    public int score = 0;

    //Musica
    public AudioSource musicSource;
    public bool isMusicOn = true;


    //Crea una instancio y la destruye si esta repetida 
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);

            
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void sumBag(int value)
    {
        bag += value;
    }

    public void sumSword(int value)
    {
        sword += value;
        Debug.Log("Sword sumada: " + value + " | Total sword: " + sword);
    }

    public void sumCoin(int value)
    {
        coin += value;
    }

    public void sumGreenApple(int value)
    {
        greenApple += value;
    }

    public void sumRedApple(int value)
    {
        redApple += value;
    }

    public void sumStar(int value)
    {
        star += value;
    }

    
    public void resetValue()
    {
        
        greenApple = 0;
        redApple = 0;
        star = 0;
        goldenKey = 0;
        health = 5;

        bag = 0;
        sword = 0;
        coin = 0;
    }

    //Contador
    public int TotalValue => greenApple + redApple ;
    public int Score => greenApple + redApple + star + bag + coin + sword;
    public int GreenApple { get => greenApple; set => greenApple = value; }
    public int Star { get => star; set => star = value; }
    public int RedApple { get => redApple; set => redApple = value; }
    public int GoldenKey { get => goldenKey; set => goldenKey = value; }


    public int Bag { get => bag; set => bag = value; }
    public int Sword { get => sword; set => sword = value; }
    public int Coin { get => coin; set => coin = value; }


    // Start is called before the first frame update
    void Start()
    {
        if (isMusicOn)
        {
            musicSource.Play();
        }


    }

    public void ToggleMusic()
    {
        // Toggle the music state
        isMusicOn = !isMusicOn;

        if (isMusicOn)
        {
            musicSource.Play();
        }
        else
        {
            musicSource.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
      
        

    }
    
}
