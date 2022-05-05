using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int health;
    public int defense;
    public int score;
    public float[] position = new float[3];
    
    public PlayerData(LifePlayer lp)
    {
        health = lp.life;
        defense = lp.defense;
        score = lp.score;
    }
}
