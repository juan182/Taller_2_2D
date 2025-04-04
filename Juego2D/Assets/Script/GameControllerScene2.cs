using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class GameControllerScene2 : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI txtRedApple;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        ShowAppleRed();

    }

    public void ShowAppleRed()
    {
        txtRedApple.text = GameManager.Instance.appleRedCount.ToString();
    }

}
