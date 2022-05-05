using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    float moveSpeed = 10f;

    Rigidbody2D rb;

    //Poner un Target, en este caso el Player
    Vector2  moveDirection;
    MuevePersonaje target; 

    //inicializacion 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        target = GameObject.FindObjectOfType<MuevePersonaje>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy (gameObject, 3f);
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (LifePlayer.instance.defense > 0)
            {
                LifePlayer.instance.defense -= 1;
                HUD.instance.UpdateDefense();
            }
            else if (LifePlayer.instance.defense <= 0)
            {
                if (LifePlayer.instance.life > 0)
                {
                    LifePlayer.instance.life -= 1;
                    HUD.instance.UpdateDefense();
                }
                else if (LifePlayer.instance.life == 0)
                {
                    Destroy(collision.gameObject);
                }
            }
        }else if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
