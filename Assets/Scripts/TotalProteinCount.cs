using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalProteinCount : MonoBehaviour
{
    public int totalProtein;

    [SerializeField] int incraseCount;
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
        totalProtein += incraseCount;
    }
    private void Update()
    {
        print(totalProtein);
    }
}
