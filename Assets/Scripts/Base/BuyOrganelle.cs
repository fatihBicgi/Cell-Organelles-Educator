using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyOrganelle : MonoBehaviour
{
    [SerializeField] protected private List<GameObject> organelleList = new List<GameObject>();

    private TotalProteinCount totalProteinCount;

    protected private readonly int organellePurchaseValue = 50;

    //SpendEnergy class �n� buna da entegre et
    protected private readonly int energySpendValue = 10;

    [SerializeField] protected private int currentOrganelleCount = 0;

    private int OrganelleListLastIndex;

    protected int maxIndex =0;

    protected private MitokondriaWork mitokondriaWork;

    private void Start()
    {
        mitokondriaWork = FindObjectOfType <MitokondriaWork>();

        totalProteinCount = FindObjectOfType <TotalProteinCount>();       

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
        if (BuyOrganelleConditions())
        {
            organelleList[currentOrganelleCount].SetActive(true);

            currentOrganelleCount++;

            DecraseTotalProtein();
            DecreaseEnergyForPurchase();

        }

        else
        {
            print("you can not purchase organelle!");
        }
    }

    protected private bool BuyOrganelleConditions()
    {
        return 
            totalProteinCount.GetTotalProtein() >= organellePurchaseValue 
            && currentOrganelleCount < maxIndex 
            && mitokondriaWork.GetCurrentEnergy() >= energySpendValue;
    }

    protected private void DecreaseEnergyForPurchase()
    {
        mitokondriaWork.SetCurrentEnergy(energySpendValue);
    }

    protected private void DecraseTotalProtein()
    {
        totalProteinCount.DecreaseTotalProtein(organellePurchaseValue);
    }
    public int GetCurrentOrganelleCount()
    {
        return currentOrganelleCount;
    }


    public void ReduceOrganelle()
    {
        if(currentOrganelleCount <=0 )
        {
            print("you have not enough organelle");
        }

        else
        {
            organelleList[GetOrganelleListLastIndex()].SetActive(false);

            currentOrganelleCount--;
        }
        
    }

    public int GetOrganelleListLastIndex()
    {
        return
              OrganelleListLastIndex = GetCurrentOrganelleCount() - 1;
    }
}
