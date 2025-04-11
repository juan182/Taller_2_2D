using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logro : RecolectableBase
{
    int starAmount=100;
    public AudioClip audio;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumStar(starAmount);
        if (audio != null)
        {
            AudioSource.PlayClipAtPoint(audio, Camera.main.transform.position);
        }
        DestroyItem();
    }
}
