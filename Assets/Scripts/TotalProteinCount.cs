using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalProteinCount : MonoBehaviour
{
    public int totalProtein;

    [SerializeField] Text totalProteinDisplay;

    [SerializeField] int increaseCount;

    // Start is called before the first frame update
    private void OnEnable()
    {
        PackClickStates.MouseDowned += IncreaseTotalProtein;
    }
    private void OnDisable()
    {
        PackClickStates.MouseDowned -= IncreaseTotalProtein;
    }

    private void IncreaseTotalProtein()
    {
        totalProtein += increaseCount;
    }
    private void Update()
    {
        totalProteinDisplay.text = totalProtein.ToString();

        print(totalProtein);
    }
}
