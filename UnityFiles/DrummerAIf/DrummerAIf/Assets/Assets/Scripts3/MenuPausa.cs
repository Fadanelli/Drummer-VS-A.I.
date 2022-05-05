using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    //Panel menu pausa
    public GameObject panelPausa;
    public bool estaPausado = false;

    public void Pausar()
    {
        estaPausado = !estaPausado;
        panelPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0 : 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }

    }
}
