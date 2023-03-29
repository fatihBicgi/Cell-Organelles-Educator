using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SetMinEnergy(int energy)
	{
		//slider.maxValue = energy;
		slider.value = energy;

		fill.color = gradient.Evaluate(1f);
	}

	public void SetEnergy(int health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}
