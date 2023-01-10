using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackClickStates : MonoBehaviour
{
    public static event Action MouseDowned;

    private void OnMouseDown()
    {
        MouseDowned?.Invoke();
    }
    private void OnMouseUp()
    {
        DestroyThisGameobject();
    }

    private void DestroyThisGameobject()
    {
        Destroy(gameObject);
    }
}
