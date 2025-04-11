using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public string playerName;
    public int score;
    public string time;
    public int greenApple;
    public int redApple;
    public int star;
    public int sword;
    public int coin;
    public int bag;

    public GameData(string name, int score, string time, int gApple, int rApple, int stars, int swords, int coins, int bags)
    {
        playerName = name;
        this.score = score;
        this.time = time;
        greenApple = gApple;
        redApple = rApple;
        star = stars;
        sword = swords;
        coin = coins;
        bag = bags;
    }
}

