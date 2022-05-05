using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winpanel : MonoBehaviour
{
    public static Winpanel instance;
    public GameObject panelPausa;
    public bool gana = false;
    private void Awake()
    {
        instance = this;
    }
    public void YaGano()
    {
        gana = !gana;
        panelPausa.SetActive(gana);
        Time.timeScale = gana ? 0 : 1;
    }

}
