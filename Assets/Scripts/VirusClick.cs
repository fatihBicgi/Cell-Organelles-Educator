using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusClick : SpendEnergy
{
    private int clickCounter=0;

    private int maxClickCount=3;

    private void OnMouseDown()
    {
        clickCounter++;

        if (clickCounter >= maxClickCount)
            Destroy(gameObject);

        DecreaseEnergy(energySpendValue);
    }

}
