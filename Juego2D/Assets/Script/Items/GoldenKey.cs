using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenKey : RecolectableBase
{
    
    public string nameScene;
    public AudioClip audioGK;

    public override void Collect(GameObject collector)
    {
        if (audioGK != null)
        {
            AudioSource.PlayClipAtPoint(audioGK, Camera.main.transform.position);
        }
        DestroyItem();
        SceneManager.LoadScene(nameScene);
    }


}
