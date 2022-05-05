using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_m : MonoBehaviour
{
	public int salud;
	public GameObject deatheff;

	public void TomaDano(int dano)
	{
		salud -= dano;
	}

	// Use this for initialization
	void Update()
	{
		if (salud <= 0)
		{
			Instantiate(deatheff, transform.position, Quaternion.identity);
			Destroy(gameObject, 0.1f);
		}


	}
}
