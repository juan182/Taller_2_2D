using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectRecolected : MonoBehaviour
{
    private int item = 0;
    public int value = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            item += value;
            GameManager.Instance.sumValue(item);
            Destroy(gameObject);
        }
    }
}
