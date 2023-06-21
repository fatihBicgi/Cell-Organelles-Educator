using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : ExtracellularMovement
{
    [SerializeField] GameObject hitEffect;

    void OnCollisionEnter(Collision collision)
    {
        //ba�ka bir objeye de�erse de patlar
        //bu kas�tl� yap�ld�
        Effect();
        Destroy(gameObject);
    }

    private void Effect()
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
    }
}
