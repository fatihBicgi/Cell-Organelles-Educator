using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyOrganelle : MonoBehaviour
{
    [SerializeField] protected private List<GameObject> organelleList = new List<GameObject>();

    private TotalProteinCount totalProteinCount;

    private readonly int organellePurchaseValue = 50;

    [SerializeField] protected int currentOrganelleCount = 0;

    int maxIndex=0;

    private void Start()
    {
        totalProteinCount = FindObjectOfType< TotalProteinCount>();       

        int maxIndexCount = 0;

        foreach (Transform child in gameObject.transform)
        {
            maxIndexCount++;
            organelleList.Add(child.gameObject);
        }

        maxIndex= maxIndexCount;
    }
    
    public void BuyOrganelleButton()
    {      
       if(totalProteinCount.GetTotalProtein() >= organellePurchaseValue && currentOrganelleCount < maxIndex)
        {
            organelleList[currentOrganelleCount].SetActive(true);

            currentOrganelleCount++;

            DecraseTotalProtein();
        }

       else
        {
            print("you can not purchase organelle!");
        }
    }

    private void DecraseTotalProtein()
    {
        totalProteinCount.DecreaseTotalProtein(organellePurchaseValue);
    }
}
