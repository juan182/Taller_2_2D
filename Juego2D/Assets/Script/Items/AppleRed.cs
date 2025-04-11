using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleRed : RecolectableBase
{
    public int points = 10;
    public AudioClip audioAR;
    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumRedApple(points);

        if (audioAR != null)
        {
            AudioSource.PlayClipAtPoint(audioAR, Camera.main.transform.position);
        }

        DestroyItem();
    }
}
