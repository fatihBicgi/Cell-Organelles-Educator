using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitokondriaWork : MonoBehaviour
{
	public int minEnergy = 0;
    public int currentEnergy;
	public EnergyBar energyBar;

	int energyValue = 1;

    private float MaxTime = 2f;

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

		print(currentTime);

		if (MaxTime < currentTime)
		{
			currentTime = 0;
			print("girdim");
			currentEnergy += energyValue* buyMitokondria.currentOrganelleCount;

			energyBar.SetEnergy(currentEnergy);
	      
		}	
     
	}
}
