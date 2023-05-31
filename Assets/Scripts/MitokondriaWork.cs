using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitokondriaWork : MonoBehaviour
{
	public int minEnergy = 0;
    public int currentEnergy;
	public EnergyBar energyBar;

	[SerializeField] int energyValue = 2;

	[SerializeField] private float MaxTime = 2f;

    private float currentTime = 0f;

	BuyMitokondria buyMitokondria;

	// Start is called before the first frame update
	void Start()
	{
		buyMitokondria = gameObject.GetComponent<BuyMitokondria>();

		currentEnergy = minEnergy;
		energyBar.SetMinEnergy(minEnergy);
	}

	// Update is called once per frame
	void Update()
	{
		currentTime += Time.deltaTime;

		if (MaxTime < currentTime)
		{
			currentTime = 0;

			if(currentEnergy < 100)
            {
				currentEnergy += energyValue * buyMitokondria.GetCurrentOrganelleCount();
				
			}						
	      
		}		
		if (currentEnergy > 100)
		{
			currentEnergy = 100;

		}

		energyBar.SetEnergy(currentEnergy);
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
