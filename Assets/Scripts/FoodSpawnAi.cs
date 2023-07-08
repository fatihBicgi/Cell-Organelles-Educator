using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawnAi : MonoBehaviour
{
    BuyRibosome buyRibosome;
    Spawn spawn;
    private void Start()
    {

        buyRibosome = FindObjectOfType<BuyRibosome>();
        spawn = gameObject.GetComponent<Spawn>();
    }

    void Update()
    {
        if (CurrentRibosomeCount() < 2)
        {
            spawn.SetNewMaxTime();
        }
        else
            spawn.SetNormalMaxTime();
    }

    private int CurrentRibosomeCount()
    {
        return buyRibosome.GetCurrentOrganelleCount();
    }

}
