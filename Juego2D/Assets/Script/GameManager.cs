using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    
    //Recolectables
    private int greenApple = 0;
    private int redApple = 0;
    private int star = 0;
    private int goldenKey = 0;

    public int health = 5;

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

    public void resetValue(int value)
    {
        
        greenApple = 0;
        redApple = 0;
        star = 0;
        goldenKey = 0;
        health = 5;
    }

    //Contador
    public int TotalValue => greenApple + redApple + star;

    public int GreenApple { get => greenApple; set => greenApple = value; }
    public int Star { get => star; set => star = value; }
    public int RedApple { get => redApple; set => redApple = value; }
    public int GoldenKey { get => goldenKey; set => goldenKey = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
