using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : ExtracellularMovement
{
    private float time = 10f;

    void Awake()
    {
        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);

    }
}
