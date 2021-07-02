using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Options Panel")] 
    [SerializeField] private GameObject optionPanel;
    
    [SerializeField] private GameObject pauseButton;

   public void LoadLevel(int index)
    {
        SceneManager.LoadScene(sceneBuildIndex: index, LoadSceneMode.Single);
    }

    public void OpenPauseMenu()
    {
        optionPanel.SetActive(true);
        pauseButton.SetActive(false);
        AudioManager.instance.PlayClickSound();
        Time.timeScale = 0;
    }

    public void ClosePauseMenu()
    {
        AudioManager.instance.PlayClickSound();
        optionPanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void OpenOptionMenu()
    {
        optionPanel.SetActive(true);
    }

    public void CloseOptionMenu()
    {
        optionPanel.SetActive(false);
    }

    public void ApplicationQuit()
    {
        Application.Quit();
    }
}