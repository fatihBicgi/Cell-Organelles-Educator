using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> squareList = new List<GameObject>();

    int protein = 1500;
    int listcontrol = 0;

    // Update is called once per frame
    void Update()
    {
        
    }


 
    public void gameObjectActive()
    {
        
       if(protein>50 && listcontrol<7)
        {
            squareList[listcontrol].SetActive(true);
            listcontrol++;
            protein -= 50;
            print(protein);

        }

    }

}
