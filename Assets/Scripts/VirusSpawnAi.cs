using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawnAi : MonoBehaviour
{
    BuyMitokondria buyMitokondria;
    Spawn spawn;

    private void Start()
    {
        buyMitokondria = FindObjectOfType<BuyMitokondria>();
        spawn = gameObject.GetComponent<Spawn>();
    }

    void Update()
    {
        if (CurrentMitokondriaCount() > 3)
        {
            spawn.SetNewMaxTime();
        }
        
    }

    private int CurrentMitokondriaCount()
    {
        return buyMitokondria.GetCurrentOrganelleCount();
    }
}
