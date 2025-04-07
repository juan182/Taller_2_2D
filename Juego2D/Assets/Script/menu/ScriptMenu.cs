using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScriptMenu : MonoBehaviour
{
    private MovePlayer player;

    //Panel
    public GameObject GameOver;
    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<MovePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            abrirMenu();
        }
        if (player.Health <= 0) Derrota();
    }

    public void Derrota()
    {
            GameOver.SetActive(true);
            Time.timeScale = 0;
    }

    public void abrirMenu()
    {
        bool isActive = Menu.activeSelf;

        Menu.SetActive(!Menu.activeSelf);

        if (isActive)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
