using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public Transform player;
    public Transform levelEnd;
    public Slider progressSlider;

    private float distancia;

    // Start is called before the first frame update
    void Start()
    {
        distancia = Vector2.Distance(player.position, levelEnd.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distanceLeft = Vector2.Distance(player.position, levelEnd.position);
        float progress = 1 - (distanceLeft / distancia);
        progressSlider.value = progress;
    }
}
