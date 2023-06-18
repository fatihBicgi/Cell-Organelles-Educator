using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtracellularMovement : MonoBehaviour
{
    [SerializeField] private float currentMoveSpeed = 1.5f;

    private float degreesPerSecond = 180;

    void Update()
    {
        Rotate();
        TranslateForward();
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
    }

    private void TranslateForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * currentMoveSpeed);
    }
}
