using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGreen : RecolectableBase
{
    public int points = 2;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.AddScore(points);
        DestroyItem();
    }
}
