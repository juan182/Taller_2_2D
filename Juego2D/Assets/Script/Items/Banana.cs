using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : RecolectableBase
{
    public float speedBoost = 2f;
    public float duration = 2f;
    public AudioClip audioB;
    public override void Collect(GameObject collector)
    {
        if (audioB != null)
        {
            AudioSource.PlayClipAtPoint(audioB, Camera.main.transform.position);
        }
        MovePlayer play = collector.GetComponent<MovePlayer>();
        if (play != null)
            play.SpeedBoost(speedBoost, duration);

        DestroyItem();
    }
}
