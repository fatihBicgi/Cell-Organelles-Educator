using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpendEnergy : MonoBehaviour
{
    protected private MitokondriaWork mitokondriaWork;

    [SerializeField] protected private int energySpendValue = 5;

    private void Start()
    {
        mitokondriaWork = FindObjectOfType<MitokondriaWork>();
    }

    public void DecreaseEnergy()
    {
        mitokondriaWork.SetCurrentEnergy(energySpendValue);
    }
}
