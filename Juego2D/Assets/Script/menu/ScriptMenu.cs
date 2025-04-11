using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScriptMenu : MonoBehaviour
{
    //Panel
    public GameObject Menu;

    private void Start()
    {
        Menu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
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
