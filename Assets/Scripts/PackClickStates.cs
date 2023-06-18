using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackClickStates : MonoBehaviour
{
    public static event Action PackCollected;

    private MitokondriaWork mitokondriaWork;

    private int energySpendValue=5;

    private void Start()
    {
        mitokondriaWork = FindObjectOfType<MitokondriaWork>();
    }
    private void OnMouseDown()
    {
        PackCollected?.Invoke();
        DecreaseEnergy();

    }
    private void OnMouseUp()
    {  
        PackSetActiveFalse();
    }
    private void PackSetActiveFalse()
    {
        gameObject.SetActive(false);
    }
    private void DecreaseEnergy()
    {
        mitokondriaWork.SetCurrentEnergy(energySpendValue);
    }
}
