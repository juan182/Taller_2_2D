using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleRed : RecolectableBase
{
    public int points = 10;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumAppleRed(points);
        DestroyItem();
    }
}
