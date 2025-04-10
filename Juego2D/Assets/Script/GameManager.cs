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

    public int score = 0;
    public float timePlayed = 0f;
    public int health = 5;

    public int listonesRecolectados = 0;
    public bool logroDesbloqueado = false;

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
        timePlayed += Time.deltaTime;
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void AddBadge()
    {
        listonesRecolectados++;
        Debug.Log("Listones: " + listonesRecolectados);

        // Lógica para logros
        if (listonesRecolectados >= 3 && !logroDesbloqueado)
        {
            LogroDesbloqueado("Logros ?");
        }
    }

    private void LogroDesbloqueado(string nombreLogro)
    {
        logroDesbloqueado = true;
        Debug.Log("¡Logro desbloqueado! " + nombreLogro);

    }


    public void SaveResults()
    {
        GameData data = new GameData(score, timePlayed);
        DataSave.GuardarJson(data);
    }

}
