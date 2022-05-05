using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float Speed = 4.5f;
    public int dano;
    public float distance;
    public LayerMask whatIsSolid;
    private void Update()
    {
      transform.position += transform.right * Time.deltaTime * Speed;
      RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance,whatIsSolid);
      Destroy(gameObject, 5f);
        if (hitInfo.collider != null){
          if (hitInfo.collider.CompareTag("Enemy")){
               Debug.Log("El enemigo debe recibir daño!");
               hitInfo.collider.GetComponent<enemy_move>().TomaDano(dano);
                LifePlayer.instance.score +=40 ;
                HUD.instance.UpdateScore();
                Destroy(gameObject);
            }
      }
    }


}
