using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Jhon;
    void Update()
    {
        Vector3 position = transform.position;
        position.x= Jhon.transform.position.x;
        position.y = Jhon.transform.position.y;
        transform.position = position;
    }
}
