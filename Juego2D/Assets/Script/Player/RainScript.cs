using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainScript : MonoBehaviour
{
    public GameObject Jhon;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = Jhon.transform.position.x;
        transform.position = position;

        if (Jhon != null) return;
    }
}
