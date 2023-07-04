using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCondition1 : MonoBehaviour
{
    [SerializeField] GameObject ribosomeControl;

    [SerializeField] GameObject lysosomeControl;
    [SerializeField] GameObject mitokondriaControl;
    [SerializeField] GameObject LysosomeCondition;
    [SerializeField] GameObject RibosomeCondition;
    [SerializeField] GameObject MitokondriaCondition;
    [SerializeField] GameObject ProteinBoxCondition;
    [SerializeField] GameObject [] proteinBoxControl;
    private int currentBoxIndex;
    private bool isActivatedBoxCondition = false; 

    public GameObject nextPanel;


    private bool isRibosomeWorked=false;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (lysosomeControl.activeSelf)
        {
            LysosomeCondition.SetActive(true);


        }
        if (ribosomeControl.activeSelf)
        {
            RibosomeCondition.SetActive(true);


        }
        if (mitokondriaControl.activeSelf)
        {
            MitokondriaCondition.SetActive(true);

        }
        if(isRibosomeWorked == true && !isActivatedBoxCondition )
        {
            if (!proteinBoxControl[currentBoxIndex].activeSelf)
            {
                ProteinBoxCondition.SetActive(true);
                currentBoxIndex++;
                isActivatedBoxCondition = true;
            }
        }

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
        if (lysosomeControl.activeSelf && mitokondriaControl.activeSelf && isRibosomeWorked)
        {

            Time.timeScale = 0f;
            nextPanel.SetActive(true);

        }
    }

}
