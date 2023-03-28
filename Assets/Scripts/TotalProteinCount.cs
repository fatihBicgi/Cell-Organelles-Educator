using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalProteinCount : MonoBehaviour
{
    [SerializeField] private int totalProtein=50;

    public int GetTotalProtein()
    {
        return totalProtein;
    }
    public void IncreaseTotalProtein(int IncreaseCount)
    {
        totalProtein += IncreaseCount;
    }
    public void DecreaseTotalProtein(int DecreaseCount)
    {
        totalProtein -= DecreaseCount;
    }

}
