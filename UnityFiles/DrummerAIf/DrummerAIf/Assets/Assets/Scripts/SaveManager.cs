using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static void SavePlayerData(LifePlayer Lp)
    {
        PlayerData PD = new PlayerData(Lp);
        
    }
}
