using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusClick : SpendEnergy
{
    

    private int clickCounter=0;

    private int maxClickCount=3;

    public static event Action VirusDefeated;

    LysosomeWork lysosomeWork;

    private void Start()
    {
        lysosomeWork = FindObjectOfType<LysosomeWork>();
    }
    private void OnMouseDown()
    {
        clickCounter++;

        if (clickCounter >= maxClickCount)
        {
           

            if (lysosomeWork.GetCurrentLysosomeCount() > 0)      
            {
                LysosomeWorks();
                Destroy(gameObject);
            }       

            else
            {
                print("you have not enough LYSOSOME");
            }

        }

        DecreaseEnergy(energySpendValue);
    }

    private void LysosomeWorks()
    {
        VirusDefeated?.Invoke();
    }
}
