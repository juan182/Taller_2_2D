using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenKey : RecolectableBase
{
    
    public string nameScene;
    public AudioClip audio;

    public override void Collect(GameObject collector)
    {
        if (audio != null)
        {
            AudioSource.PlayClipAtPoint(audio, Camera.main.transform.position);
        }
        DestroyItem();
        SceneManager.LoadScene(nameScene);
    }


}
