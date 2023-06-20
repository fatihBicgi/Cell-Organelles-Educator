using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LysosomeWork : MonoBehaviour
{
   
    
    BuyLysosomes buyLysosomes;

    private void Start()
    {
        buyLysosomes = gameObject.GetComponent<BuyLysosomes>();
    
    }

    private void OnEnable()
    {
        VirusClick.VirusDefeated += LysosomeDone;
    }
    private void OnDisable()
    {
        VirusClick.VirusDefeated -= LysosomeDone;
    }
    private void LysosomeDone()
    {

        buyLysosomes.ReduceOrganelle();
    }

    public int GetCurrentLysosomeCount()
    {
        return buyLysosomes.GetCurrentOrganelleCount();
    }
    
}
