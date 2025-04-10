using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logro : RecolectableBase
{
    public override void Collect(GameObject collector)
    {
        GameManager.Instance.LogroDesbloqueado("Collected a star!");
        DestroyItem();
    }
}
