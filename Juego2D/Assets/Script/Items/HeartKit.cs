using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartKit : MonoBehaviour, Recolectable
{
    public int heal = 3;

    public void Collect(GameObject collector)
    {
        MovePlayer player = collector.GetComponent<MovePlayer>();
        if (player != null)
        {
            player.HealUp(heal);
        }
            

        Destroy(gameObject);
    }
}
