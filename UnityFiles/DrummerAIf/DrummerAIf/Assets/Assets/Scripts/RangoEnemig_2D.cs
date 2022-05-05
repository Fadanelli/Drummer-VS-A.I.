using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemig_2D : MonoBehaviour
{
    public Animator ani;
    public Patrullar enemigo;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            ani.SetBool("walk", false);
            ani.SetBool("run", false);
            ani.SetBool("attack", true);
            enemigo.atacando= true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
