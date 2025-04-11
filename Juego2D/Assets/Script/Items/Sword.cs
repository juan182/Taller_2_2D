using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : RecolectableBase
{
    int swordAmount = 50;
    public AudioClip audioSw;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumSword(swordAmount);
        if (audioSw != null)
        {
            AudioSource.PlayClipAtPoint(audioSw, Camera.main.transform.position);
        }
        DestroyItem();
    }
}
