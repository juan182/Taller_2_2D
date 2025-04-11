using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Recolectable collectible = GetComponent<Recolectable>();
            if (collectible != null)
            {
                collectible.Collect(collision.gameObject);
            }
        }
    }

    
}
