using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] protected private List<GameObject> squareList = new List<GameObject>();

    private TotalProteinCount totalProteinCount;

    private int proteinBuyCount = 50;

    protected int currentCount = 0;

    int maxIndex=0;

    private void Start()
    {
        totalProteinCount = FindObjectOfType< TotalProteinCount>();       

        int maxIndexCount = 0;

        foreach (Transform child in gameObject.transform)
        {
            maxIndexCount++;
            squareList.Add(child.gameObject);
        }

        maxIndex= maxIndexCount;
    }
    
    public void GameObjectActive()
    {
        

       if(totalProteinCount.GetTotalProtein() >= proteinBuyCount && currentCount < maxIndex)
        {
            squareList[currentCount].SetActive(true);

            currentCount++;

            totalProteinCount.DecreaseTotalProtein(proteinBuyCount);

            print("ssadwqdqwd"+ totalProteinCount.GetTotalProtein() );

        }
    }

}
