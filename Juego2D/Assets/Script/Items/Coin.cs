using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : RecolectableBase
{
    int coinAmount = 5;
    public AudioClip audioC;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumCoin(coinAmount);
        if (audioC != null)
        {
            AudioSource.PlayClipAtPoint(audioC, Camera.main.transform.position);
        }
        DestroyItem();
    }
}
