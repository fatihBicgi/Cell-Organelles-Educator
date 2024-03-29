using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibosomeWork : SpendEnergy
{  

    private Transform child;
    [SerializeField] private GameObject box;

    [SerializeField] private bool isWorking=false;

    private int workTime = 4;
    //tekrar eden �eyler, enerji harc�yorsa ayn� �ekilde harc�yorlar de�erler bile ayn�
    //bu kod tekrar�ndan kurtul


    void Awake()
    {
        energySpendValue = 10;
        child = gameObject.transform.GetChild(7);
        box = child.gameObject;

    }

    private void OnMouseDown()
    {
        if (OrganelleWorkConditions())
        {

            DecreaseEnergy();

            isWorking = true;
            CreatePack();

        }
        else print("Collect The Pack First!");

    }

    private bool isBoxDeactive()
    {
        return !box.activeInHierarchy;
    }

    private void CreatePack()
    {
        print("ribosom starts working");

        StartCoroutine(WorkCoroutine());
    }
    IEnumerator WorkCoroutine()
    {
             
        yield return new WaitForSeconds(workTime);

        box.SetActive(true);

        print("ribosom finished working");
        isWorking = false;
    }

    private bool OrganelleWorkConditions()
    {
        return           
            !isWorking & isBoxDeactive()     
            && mitokondriaWork.GetCurrentEnergy() >= energySpendValue;
    }
}
