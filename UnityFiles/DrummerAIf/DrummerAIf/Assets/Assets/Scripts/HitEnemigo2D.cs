using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemigo2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            print("Hit");
        }
    }
}
