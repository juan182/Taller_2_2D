using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : RecolectableBase
{
    public float speedBoost = 2f;
    public float duration = 5f;

    public override void Collect(GameObject collector)
    {
        MovePlayer play = collector.GetComponent<MovePlayer>();
        if (play != null)
            play.SpeedBoost(speedBoost, duration);

        DestroyItem();
    }
}
