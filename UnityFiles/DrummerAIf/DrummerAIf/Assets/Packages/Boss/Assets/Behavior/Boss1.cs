using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    float Cadencia;
    float SigDisparo;

    // Inicializacion 
    private void Start()
    {
        Cadencia = 5F;
        SigDisparo = Time.time;
    }

    private void Update()
    {
        CheckIfTimeToFire ();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > SigDisparo)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            SigDisparo = Time.time + Cadencia;
        }
    }
}
