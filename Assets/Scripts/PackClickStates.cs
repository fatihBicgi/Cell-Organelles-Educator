using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackClickStates : MonoBehaviour
{
    public static event Action PackCollected;

    private void OnMouseDown()
    {
        PackCollected?.Invoke();
    }
    private void OnMouseUp()
    {
       
        PackSetActiveFalse();
    }
    private void PackSetActiveFalse()
    {
        gameObject.SetActive(false);
    }
   
}
