using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    private float currentMoveSpeed= 1.5f;
    private float degreesPerSecond = 180;
     

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,0 , degreesPerSecond) * Time.deltaTime);
        TranslateForward();
    }
    private void TranslateForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * currentMoveSpeed);
    }
}
