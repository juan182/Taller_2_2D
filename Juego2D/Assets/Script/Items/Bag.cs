using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : RecolectableBase
{
    int bag = 20;
    public AudioClip audioB;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumBag(bag);
        if (audioB != null)
        {
            AudioSource.PlayClipAtPoint(audioB, Camera.main.transform.position);
        }
        DestroyItem();
    }
}
