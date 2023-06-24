using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject LevelsPanel;
    public GameObject Menu;
   
    // Start is called before the first frame update

public void playButtonClick()
    {
        MenuPanel.SetActive(false);
        LevelsPanel.SetActive(true);

    }
    public void RetryFunction()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }


    public void GamePaused()
    {
        Time.timeScale = 0f;
        Menu.SetActive(true);

    }
    public void GameResume()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);

    }


    public void Level1MenuButtonClick()
    {
        LevelMenuButtonClick(1);
    }
    public void Level2MenuButtonClick()
    {
        LevelMenuButtonClick(2);
    }
    public void Level3MenuButtonClick()
    {
        LevelMenuButtonClick(3);
    }
    private void LevelMenuButtonClick(int levelIndex)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - levelIndex);
    }


    public void playLevel1Button()
    {
        LevelAvaliable(1);
    }

public void playLevel2Button()
    {
        LevelAvaliable(2);
    }

public void playLevel3Button()
    {
        LevelAvaliable(3);

    }
    public void NextLevelAvaliable()
    {
        LevelAvaliable(1);
    }
 
    private void LevelAvaliable(int levelIndex)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + levelIndex);

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
