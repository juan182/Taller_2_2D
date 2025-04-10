using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PatrollScript : MonoBehaviour
{
    //Coordenadas
    public GameObject PointA;
    public GameObject PointB;
    private Transform currentPoint;

    //Objeto
    private Rigidbody2D Rigidbody;
    private MovePlayer Player;

    //Velocidad
    private float speed = 1;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        currentPoint = PointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == PointB.transform)
        {
            Rigidbody.velocity = new Vector2(speed, 0);
        }else
        {
            Rigidbody.velocity = new Vector2 (-speed, 0);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5 && currentPoint == PointB.transform)
        {
            currentPoint = PointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5 && currentPoint == PointA.transform)
        {
            currentPoint = PointB.transform;
        }
    }
}
