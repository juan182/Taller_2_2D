using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldenKey : RecolectableBase
{
    public int point=1;
    public string nameScene;

    public override void Collect(GameObject collector)
    {
        GameManager.Instance.AddKey(point);
        DestroyItem();
        SceneManager.LoadScene(nameScene);
    }


}
