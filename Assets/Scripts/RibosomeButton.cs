using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibosomeButton : MonoBehaviour
{
    public List<GameObject> squareList = new List<GameObject>();

    int protein = 1500;
    int listcontrol = 0;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void gameObjectActive()
    {

        if (protein > 50 && listcontrol < 5)
        {
            squareList[listcontrol].SetActive(true);
            listcontrol++;
            protein -= 50;

            print(protein);
            

        }

    }
}
