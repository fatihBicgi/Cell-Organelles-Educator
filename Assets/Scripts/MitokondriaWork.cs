using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitokondriaWork : MonoBehaviour
{
    private const int highEnergyLimit = 50; //100 üzerinden

    public int minEnergy = 0;
    public int currentEnergy;

	public EnergyBar energyBar;

	[SerializeField] int energyValue = 2;
	[SerializeField] int standartEnergyValue = 2;
	[SerializeField] int reducedEnergyValue = 1;

	[SerializeField] private float MaxTime = 3f;
    private float currentTime = 0f;

	BuyMitokondria buyMitokondria;

	void Start()
	{

		energyValue = standartEnergyValue;

		buyMitokondria = gameObject.GetComponent<BuyMitokondria>();

		currentEnergy = minEnergy;
		energyBar.SetMinEnergy(minEnergy);
	}

	void Update()
    {
        currentTime += Time.deltaTime;

        if (MaxTime < currentTime)
        {
            currentTime = 0;

            if (currentEnergy < 100)
            {
                currentEnergy += energyValue * buyMitokondria.GetCurrentOrganelleCount();

            }

        }
        if (currentEnergy > 100)
        {
            currentEnergy = 100;

        }

        IfEnergyIsHighDecreaseEnergyValue();

        energyBar.SetEnergy(currentEnergy);
    }

    private void IfEnergyIsHighDecreaseEnergyValue()
    {
        if (currentEnergy >= highEnergyLimit)
            energyValue = reducedEnergyValue;
        else
            energyValue = standartEnergyValue;
    }

    public int GetCurrentEnergy()
    {
		return currentEnergy;
    }
	public void SetCurrentEnergy(int DecreaseEnergy)
    {
		currentEnergy -= DecreaseEnergy;
    }
}
