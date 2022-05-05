using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{


	public int salud;

	public GameObject deatheff;

	public void TomaDano(int dano)
	{
		salud -= dano;
		if (salud <= 0)
        {
			KO();
        }
	}

	// Use this for initialization

	void KO() 
	{ 
		LifePlayer.instance.score += 50;
		HUD.instance.UpdateScore();
		Instantiate(deatheff, transform.position, Quaternion.identity);
		Destroy(gameObject, 0.1f);
	}
}
