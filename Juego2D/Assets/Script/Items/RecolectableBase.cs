using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RecolectableBase : MonoBehaviour, Recolectable
{
    public abstract void Collect(GameObject collector);

    protected void DestroyItem()
    {
        Destroy(gameObject);
    }
}
