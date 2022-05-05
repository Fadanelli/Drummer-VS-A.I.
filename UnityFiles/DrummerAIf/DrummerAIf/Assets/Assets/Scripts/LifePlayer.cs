using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePlayer : MonoBehaviour
{
    public int life = 3;
    public int defense = 0;
    public int score = 0;

    public static LifePlayer instance;

    private void Awake()
    {
        instance = this;
    }
}
