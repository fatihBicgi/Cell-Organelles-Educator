using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    
    public GameObject[] tutorialMessageBox;
    public GameObject MitokondriaButton;
    public GameObject RibosomeButton;
    public GameObject LysosomeButton;
    public GameObject TutorialPanel;
    public GameObject[] SpotLights;
    [SerializeField] GameObject virus;
    [SerializeField] GameObject food;
    [SerializeField] GameObject gameControlPanel;
 
    public GameObject spawnMitokondria;
    public GameObject spawnRibosome;
    public GameObject spawnLysosome;
    private int currentPanelIndex = 0;
    private int currentLightIndex = 0;
    
    private void Awake()
    {
        tutorialMessageBox[currentPanelIndex].SetActive(true);
        MitokondriaButton.SetActive(false);
        RibosomeButton.SetActive(false);
        LysosomeButton.SetActive(false);
        Time.timeScale = 0f;



    }

    private void Start()
    {
    }

    private void Update()
    {
        if (currentPanelIndex <= tutorialMessageBox.Length - 8)   //
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
        else if (currentPanelIndex <= tutorialMessageBox.Length - 7)   //
        {
            if (Input.GetMouseButtonDown(0))
            {
                virus.SetActive(true);
                tutorialMessageBox[currentPanelIndex].SetActive(false);
                SpotLights[currentLightIndex].SetActive(false);
                currentPanelIndex++;
                currentLightIndex++;
                tutorialMessageBox[currentPanelIndex].SetActive(true);
                SpotLights[currentLightIndex].SetActive(true);
            }
        }
        else if (currentPanelIndex <= tutorialMessageBox.Length - 6)   //
        {
            if (Input.GetMouseButtonDown(0))
            {
                virus.SetActive(false);
                food.SetActive(true);
                tutorialMessageBox[currentPanelIndex].SetActive(false);
                SpotLights[currentLightIndex].SetActive(false);
                currentPanelIndex++;
                currentLightIndex++;
                tutorialMessageBox[currentPanelIndex].SetActive(true);
                SpotLights[currentLightIndex].SetActive(true);
            }
        }
        else if (currentPanelIndex <= tutorialMessageBox.Length - 5)   //
        {
            if (Input.GetMouseButtonDown(0))
            {
                
                food.SetActive(false);
                gameControlPanel.SetActive(true);
                tutorialMessageBox[currentPanelIndex].SetActive(false);
                SpotLights[currentLightIndex].SetActive(false);
                currentPanelIndex++;
                currentLightIndex++;
                tutorialMessageBox[currentPanelIndex].SetActive(true);
                SpotLights[currentLightIndex].SetActive(true);
            }
        }
        else if(currentPanelIndex < tutorialMessageBox.Length -1)
        {

            RibosomeButton.SetActive(true);
            MitokondriaButton.SetActive(true);
            LysosomeButton.SetActive(true);
            spawnMitokondria.SetActive(false);
            spawnRibosome.SetActive(false);
            spawnLysosome.SetActive(false);
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
                food.SetActive(false);
                tutorialMessageBox[currentPanelIndex].SetActive(false);
                TutorialPanel.SetActive(false);
                Time.timeScale = 1f;
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
