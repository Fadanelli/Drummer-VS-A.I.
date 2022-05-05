using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earplug1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LifePlayer.instance.defense += 1;
            HUD.instance.UpdateDefense();
            LifePlayer.instance.score += 10;
            HUD.instance.UpdateScore();


            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.1f);

        }
    }
}
