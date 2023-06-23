using UnityEngine;

public class Level1TutorialManager : MonoBehaviour
{

    public GameObject[] tutorialMessageBox;
    public GameObject TutorialPanel;
    public GameObject NextPanel;
    public GameObject PauseButton;
    public GameObject[] SpotLights;
    


    private int currentPanelIndex = 0;
    private int currentLightIndex = 0;

    private void Awake()
    {
        tutorialMessageBox[currentPanelIndex].SetActive(true);
       
        Time.timeScale = 0f;



    }

    private void Start()
    {
    }

    private void Update()
    {
        if (currentPanelIndex <= tutorialMessageBox.Length - 6)   //
        {
            if (Input.GetMouseButtonDown(0))
            {
                tutorialMessageBox[currentPanelIndex].SetActive(false);
                SpotLights[currentLightIndex].SetActive(false);
                currentPanelIndex++;
                currentLightIndex++;
                tutorialMessageBox[currentPanelIndex].SetActive(true);
                SpotLights[currentLightIndex].SetActive(true);
            }
        }
        else if (currentPanelIndex < tutorialMessageBox.Length - 1)
        {
        
            if (Input.GetMouseButtonDown(0))
            {
                SpotLights[currentLightIndex].SetActive(false);
                tutorialMessageBox[currentPanelIndex].SetActive(false);
                currentPanelIndex++;
                currentLightIndex++;
                SpotLights[currentLightIndex].SetActive(true);
                tutorialMessageBox[currentPanelIndex].SetActive(true);
            }
        }

        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                tutorialMessageBox[currentPanelIndex].SetActive(false);
                TutorialPanel.SetActive(false);
                NextPanel.SetActive(true);
                PauseButton.SetActive(false);
                Time.timeScale = 0f;
                gameObject.SetActive(false);
            }
        }


    }

    public void ClosePanel()
    {
        tutorialMessageBox[currentPanelIndex].SetActive(false);
        
        

        currentPanelIndex++;
    }

}
