using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject Target;
    private Vector3 TargetPos;
    public float HaciaAdelante;
    public float Smoothing;


    // Update is called once per frame
    void Update()
    {
        TargetPos = new Vector3(Target.transform.position.x, Target.transform.position.y, transform.position.z);

        if (Target.transform.localScale.x == 1)
        {
            TargetPos = new Vector3(TargetPos.x + HaciaAdelante, TargetPos.y, transform.position.z);
        }
        if (Target.transform.localScale.x == -1)
        {
            TargetPos = new Vector3(TargetPos.x - HaciaAdelante, TargetPos.y, transform.position.z);
        }

        transform.position = Vector3.Lerp(transform.position, TargetPos, Smoothing * Time.deltaTime);
    }
}
