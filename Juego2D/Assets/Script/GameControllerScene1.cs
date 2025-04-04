using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class GameControllerScene1 : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI txtGreenApple;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        ShowAppleGreen();


    }

    public void ShowAppleGreen()
    {
        txtGreenApple.text = GameManager.Instance.AppleGreenCount.ToString();
    }

}
