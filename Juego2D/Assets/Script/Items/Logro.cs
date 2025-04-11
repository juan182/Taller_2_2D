using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logro : RecolectableBase
{
    int starAmount=1;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.sumStar(starAmount);
        DestroyItem();
    }
}
