using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGreen : RecolectableBase
{
    public int points = 2;

    public AudioClip audio;


    public override void Collect(GameObject collector)
    { 
        GameManager.Instance.sumGreenApple(points);

        if (audio != null)
        {
            AudioSource.PlayClipAtPoint(audio, Camera.main.transform.position);
        }

        DestroyItem();
        
    }
}
