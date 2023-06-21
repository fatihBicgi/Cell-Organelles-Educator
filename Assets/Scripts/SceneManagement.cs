using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject LevelsPanel;
    // Start is called before the first frame update

public void playButtonClick()
    {
        MenuPanel.SetActive(false);
        LevelsPanel.SetActive(true);

    }
public void playLevel1Button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
public void playLevel2Button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }
public void playLevel3Button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

    }
 public void playLevel4Button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

    }
    public void playLevel5Button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);

    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void Backspace()
    {
        MenuPanel.SetActive(true);
        LevelsPanel.SetActive(false);
    }
}
