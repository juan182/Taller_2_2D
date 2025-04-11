using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logro : RecolectableBase
{
    int starAmount=100;
    public AudioClip audioL;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumStar(starAmount);
        if (audioL != null)
        {
            AudioSource.PlayClipAtPoint(audioL, Camera.main.transform.position);
        }
        DestroyItem();
    }
}
