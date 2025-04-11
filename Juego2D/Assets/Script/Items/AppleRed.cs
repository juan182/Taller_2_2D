using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleRed : RecolectableBase
{
    public int points = 10;
    public AudioClip audio;
    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumRedApple(points);

        if (audio != null)
        {
            AudioSource.PlayClipAtPoint(audio, Camera.main.transform.position);
        }

        DestroyItem();
    }
}
