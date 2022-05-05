using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    /*
       * Autor: Jose Miguel Garcia Gurtubay Moreno
       * A01373750
       * ITC
       * Clase que guarda los puntos del personaje
    */
public class PuntosPersonaje : MonoBehaviour
{
    public int puntos = 0;
    public static PuntosPersonaje instance;

    private void Awake()
    {
        instance = this;
    }
}
