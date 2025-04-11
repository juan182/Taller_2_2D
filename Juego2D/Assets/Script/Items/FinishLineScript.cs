using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineScript : MonoBehaviour
{
    public GameObject Panel;
    private Timer timer;
    private bool contact = false;

    private void Start()
    {
        Panel.SetActive(false);
    }

    private void Update()
    {
        if(contact == true)
        {
            timer.TimerStop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Panel.SetActive(true);
            contact = true;
        }
    }
}
