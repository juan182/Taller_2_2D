using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartKit : MonoBehaviour, Recolectable
{
    public int heal = 3;

    public void Collect(GameObject collector)
    {
        HealthPlayer health = collector.GetComponent<HealthPlayer>();
        if (health != null)
        {
            health.Health(heal);
        }
            

        Destroy(gameObject);
    }
}
