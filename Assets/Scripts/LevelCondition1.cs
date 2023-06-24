using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCondition1 : MonoBehaviour
{
  
   
    public GameObject LysosomeControl;
    public GameObject MitokondriaControl;
    public GameObject NextPanel;

    private void OnEnable()
    {
        PackClickStates.PackCollected += BoxController;
    }
    private void OnDisable()
    {
        PackClickStates.PackCollected -= BoxController;
    }
   

    private void BoxController()
    {
      
        if (LysosomeControl.activeSelf && MitokondriaControl.activeSelf)
        {


            Time.timeScale = 0f;
            NextPanel.SetActive(true);

        }
    }

}
