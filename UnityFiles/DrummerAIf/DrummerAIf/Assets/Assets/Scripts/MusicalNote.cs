using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicalNote : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damage = 2;
    public float Speed = 10f;
    

    void Start()
    {
        rb.velocity = transform.right * Speed;
        Destroy(gameObject, 5f);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Enemy")
        {
            Debug.Log("El enemigo debe recibir daño!");
            collision.GetComponent<enemy_move>().TomaDano(damage);
            LifePlayer.instance.score += 40;
            HUD.instance.UpdateScore();
            Destroy(gameObject);
        }
    }
}
