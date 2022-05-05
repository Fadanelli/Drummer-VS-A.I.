using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;

public class Menu2 : MonoBehaviour
{
    public void Map2()
    {
        SceneManager.LoadScene("Mapa2");
    }

    public void leerJson()
    {
        StartCoroutine(LeerHra());
    }
    private IEnumerator LeerHra()
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
