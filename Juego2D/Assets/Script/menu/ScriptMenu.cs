using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScriptMenu : MonoBehaviour
{
    //Panel
    public GameObject Menu;
    public GameObject Final;

    private void Start()
    {
        Menu.SetActive(false);
        Final.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M) && !Final.activeSelf)
        {
            abrirMenu();
        }
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
