using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    
    public GameObject[] tutorialPanels;
    public GameObject MitoButton;
    public GameObject RiboButton;
 
    public GameObject spawnMithocondria;
    public GameObject spawnRibosome;
    private int currentPanelIndex = 0;
    
    private void Awake()
    {
        tutorialPanels[currentPanelIndex].SetActive(true);
        MitoButton.SetActive(false);
        RiboButton.SetActive(false);    
    }

    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (currentPanelIndex <= tutorialPanels.Length - 3)   //
        {
            if (Input.GetMouseButtonDown(0))
            {
                tutorialPanels[currentPanelIndex].SetActive(false);
                currentPanelIndex++;
                tutorialPanels[currentPanelIndex].SetActive(true);
            }
        }
        else if(currentPanelIndex < tutorialPanels.Length -1)
        {
            RiboButton.SetActive(true);
            MitoButton.SetActive(true);
            spawnMithocondria.SetActive(false);
            spawnRibosome.SetActive(false);
            if (Input.GetMouseButtonDown(0))
            {
              
                tutorialPanels[currentPanelIndex].SetActive(false);
                currentPanelIndex++;
                tutorialPanels[currentPanelIndex].SetActive(true);
                }
                  }
      
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                tutorialPanels[currentPanelIndex].SetActive(false);
               
                Time.timeScale = 1f;
                gameObject.SetActive(false);
            }
        }


    }

    public void ClosePanel()
    {
        tutorialPanels[currentPanelIndex].SetActive(false);
        currentPanelIndex++;
    }
    
}
