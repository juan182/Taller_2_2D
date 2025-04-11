using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGreen : RecolectableBase
{
    public int points = 2;

    public AudioClip audioAG;


    public override void Collect(GameObject collector)
    { 
        GameManager.Instance.sumGreenApple(points);

        if (audioAG != null)
        {
            AudioSource.PlayClipAtPoint(audioAG, Camera.main.transform.position);
        }

        DestroyItem();
        
    }
}
