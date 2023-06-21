using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCondition1 : MonoBehaviour
{
    public GameObject RibosomeBoxControl;
    public GameObject LysosomeControl;
    public GameObject MitokondriaControl;
    public GameObject NextPanel;

    void Update()
    {
        if (RibosomeBoxControl.activeSelf && LysosomeControl.activeSelf && MitokondriaControl.activeSelf)
        {
            Time.timeScale = 0f;
            NextPanel.SetActive(true);
        }

    }


}
