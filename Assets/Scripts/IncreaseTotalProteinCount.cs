using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseTotalProteinCount : MonoBehaviour
{
    [SerializeField] Text totalProteinDisplayText;

    [SerializeField] int increaseCount;

    private TotalProteinCount totalProteinCount;   

    private void Start()
    {
        totalProteinCount = GetComponent<TotalProteinCount>();
  
    }

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
        totalProteinCount.IncreaseTotalProtein(increaseCount);
    }
    private void Update()
    {

        totalProteinDisplayText.text = totalProteinCount.GetTotalProtein().ToString();

        print(totalProteinCount.GetTotalProtein());
    }
}
