using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;

public class Menu : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Library()
    {
        SceneManager.LoadScene("Library");
    }
    public void Salir()
    {
        Application.Quit();

    }
    public void Login()
    {
        SceneManager.LoadScene("SignIn");
    }

    public void Map1()
    {
        SceneManager.LoadScene("Mapa1");
    }

    public void leerJson()
    {
        StartCoroutine(LeerHra());
    }
    private IEnumerator LeerHra()
    {
        string Tipo = "Enter_Map_1";

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
    public void Map2()
    {
        SceneManager.LoadScene("Mapa2");
    }

    public void leerJson2()
    {
        StartCoroutine(LeerHra2());
    }
    private IEnumerator LeerHra2()
    {
        string Tipo = "Enter_Map_2";

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
