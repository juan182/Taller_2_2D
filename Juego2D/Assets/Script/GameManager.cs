using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //Contador
    private int totalValue = 0;

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

    public void sumValue(int value)
    {
        totalValue += value;
    }
    public void resetValue(int value)
    {
        totalValue = 0;
    }
    public int TotalValue { get => totalValue; set => totalValue = value; }

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
