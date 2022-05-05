using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel1 : MonoBehaviour
{
    public GameObject Panel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Destroy(gameObject, 2f);
            Winpanel.instance.YaGano();
        }
    }
}
