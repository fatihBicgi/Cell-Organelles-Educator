using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCondition1 : MonoBehaviour
{

    public GameObject ribosomeControl;
    public GameObject lysosomeControl;
    public GameObject mitokondriaControl;


    public GameObject nextPanel;


    private bool isRibosomeWorked=false;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        VirusClick.VirusDefeated += BoxController;

        RibosomeWork.ribosomeWorked += RobisomeWorkedTrue;
    }
    private void OnDisable()
    {
        VirusClick.VirusDefeated -= BoxController;

        RibosomeWork.ribosomeWorked -= RobisomeWorkedTrue;
    }

    private void RobisomeWorkedTrue()
    {
        isRibosomeWorked = true;
    }
    private void BoxController()
    {
      
        if (ribosomeControl.activeSelf && mitokondriaControl.activeSelf && isRibosomeWorked)
        {

            Time.timeScale = 0f;
            nextPanel.SetActive(true);

        }
    }

}
