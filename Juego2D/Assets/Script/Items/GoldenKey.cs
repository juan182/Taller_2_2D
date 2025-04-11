using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenKey : RecolectableBase
{
    
    public string nameScene;

    public override void Collect(GameObject collector)
    {
        
        DestroyItem();
        SceneManager.LoadScene(nameScene);
    }


}
