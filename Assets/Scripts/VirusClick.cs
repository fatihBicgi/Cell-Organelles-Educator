using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusClick : MonoBehaviour
{
    
    private int clickCounter=0;

    private int maxClickCount=3;

    public static event Action VirusDefeated;   

    MitokondriaWork mitokondriaWork;

    [SerializeField] int EnergyDecreaseValue=2;

    LysosomeWork lysosomeWork;

    private void Start()
    {
        lysosomeWork = FindObjectOfType<LysosomeWork>();

       

        mitokondriaWork = FindObjectOfType<MitokondriaWork>();
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

        DecreaseEnergy(EnergyDecreaseValue);
    }  

    private void LysosomeWorks()
    {
        VirusDefeated?.Invoke();
    }
    public void DecreaseEnergy(int EnergyValue)
    {
        mitokondriaWork.SetCurrentEnergy(EnergyValue);
    }
}
