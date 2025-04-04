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
    public GameObject goldKey;

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

    public void sumValue(int valueGreen, int valuered)
    {
        appleGreenCount += valueGreen;
        appleRedCount += valuered;
    }
    public void resetValue(int valueGreen, int valuered)
    {
        appleGreenCount = 0;
        appleRedCount = 0;
    }
    public int AppleGreenCount { get => appleGreenCount; set => appleGreenCount = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
