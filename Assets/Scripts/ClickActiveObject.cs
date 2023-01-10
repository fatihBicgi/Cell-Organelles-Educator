using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickActiveObject : MonoBehaviour
{
    // Start is called before the first frame update
  public  GameObject mitochondria;
    int i = 0;


 

    private void Start()
    {
        
    }
    private void Update()
    {
     
        
       
    }
    public void clickButton()
    {
        SpawnObject(mitochondria, transform);
        
    }
  


    // Update is called once per frame
    public void SpawnObject(GameObject objectToSpawn,Transform newTransform)
    {

        Instantiate(objectToSpawn,newTransform.position,newTransform.rotation);
    }
  


}
