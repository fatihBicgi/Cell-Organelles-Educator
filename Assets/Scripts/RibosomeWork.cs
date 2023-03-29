using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibosomeWork : MonoBehaviour
{  

    private Transform child;
    [SerializeField] private GameObject box;

    [SerializeField] private bool isWorking=false;

    private int workTime = 3;
    //tekrar eden þeyler, enerji harcýyorsa ayný þekilde harcýyorlar deðerler bile ayný
    //bu kod tekrarýndan kurtul
    int energySpendValue=5;

    MitokondriaWork mitokondriaWork;

    void Awake()
    {
        child = gameObject.transform.GetChild(7);
        box = child.gameObject;

        mitokondriaWork = FindObjectOfType<MitokondriaWork>();
    }

    private void OnMouseDown()
    {
        if (BuyOrganelleConditions())
        {

            mitokondriaWork.SetCurrentEnergy(energySpendValue);

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

    private bool BuyOrganelleConditions()
    {
        return           
            !isWorking & isBoxDeactive()     
            && mitokondriaWork.GetCurrentEnergy() >= energySpendValue;
    }
}
