using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earplug2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {


            LifePlayer.instance.defense += 2;
            HUD.instance.UpdateDefense();
            LifePlayer.instance.score += 20;
            
            HUD.instance.UpdateScore();

            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            GetComponent<SpriteRenderer>().enabled = false;

            Destroy(gameObject, 0.1f);

        }
    }
}
