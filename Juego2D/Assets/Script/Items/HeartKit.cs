using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartKit : MonoBehaviour, Recolectable
{
    public int heal = 3;
    public AudioClip audioH;

    public void Collect(GameObject collector)
    {

        if (audioH != null)
        {
            AudioSource.PlayClipAtPoint(audioH, Camera.main.transform.position);
        }
        MovePlayer player = collector.GetComponent<MovePlayer>();
        if (player != null)
        {
            player.HealUp(heal);
        }
            

        Destroy(gameObject);
    }
}
