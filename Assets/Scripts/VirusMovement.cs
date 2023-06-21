using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : ExtracellularMovement
{
    [SerializeField] GameObject hitEffect;

    void OnCollisionEnter(Collision collision)
    {
        //baþka bir objeye deðerse de patlar
        //bu kasýtlý yapýldý
        Effect();
        Destroy(gameObject);
    }

    private void Effect()
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
    }
}
