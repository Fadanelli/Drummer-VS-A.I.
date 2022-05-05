using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_shoots : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;

    //Aim zone
    public Transform aim;

    float fireRate;
    float nextFire;
    private void Start()
    {
        fireRate = 3f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }
    void CheckIfTimeToFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bullet, aim.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
