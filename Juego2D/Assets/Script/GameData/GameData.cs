using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public int finalScore;
    public float totalTime;

    public GameData(int score, float time)
    {
        finalScore = score;
        totalTime = time;
    }
}
