using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;
public class Pause : MonoBehaviour
{
    //Panel menu pausa
    [SerializeField]  private GameObject menuPausa;
    public bool estaPausado = false;

    public void Pausar()
    {
        estaPausado = !estaPausado;
        menuPausa.SetActive(estaPausado);
        Time.timeScale = estaPausado ? 0 : 1;
    }
    //Dectectar la tecla para ejecutar la pausa
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }
    public void SalirMenu()
    {
        //Cargar la escena de Mario
        SceneManager.LoadScene("MenuPrincipal");
    }
    public void Exit()
    {
        Application.Quit();   
    }
    public void leerJson()
    {
        StartCoroutine(LeerHra());
    }
    private IEnumerator LeerHra()
    {
        string Tipo = "Exit_Map_1";

        WWWForm forma = new WWWForm();
        forma.AddField("Tipo", Tipo);

        UnityWebRequest request = UnityWebRequest.Post("http://localhost/unity/enviaHra.php", forma);
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Si funciono");
        }
        else
        {
            Debug.Log("No funciono");
        }
    }
}
