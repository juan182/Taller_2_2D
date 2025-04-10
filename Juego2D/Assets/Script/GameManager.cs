using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //Contador
    public int appleGreenCount = 0;
    public int appleRedCount = 0;

    //Llave
    public int goldKey=0;

    public int score = 0;
    public float timePlayed = 0f;
    public int health = 5;
    public int star = 0;
    

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

    public void sumAppleGreen(int value)
    {
        appleGreenCount += value;
       
    }

    public void sumAppleRed(int value)
    {
        appleRedCount += value;
    }


    public void resetValue()
    {
        appleGreenCount = 0;
        appleRedCount = 0;
        goldKey = 0;
        star = 0;

    }
    public int AppleGreenCount { get => appleGreenCount; set => appleGreenCount = value; }
    public int AppleRedCount { get => appleRedCount; set => appleRedCount = value; }
    public int GoldKey { get => goldKey; set => goldKey = value; }
    public int Star { get => star; set => star = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePlayed += Time.deltaTime;
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void AddKey(int value)
    {
        goldKey += value;
    }

    public void AddStar(int value)
    {
        star += value;
    }


    public void SaveResults()
    {
        GameData data = new GameData(score, timePlayed);
        DataSave.GuardarJson(data);
    }

}
