using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Options Panel")] 
    [SerializeField] private GameObject optionPanel;
    [SerializeField] private GameObject optionTint;
    
    [SerializeField] private GameObject pauseButton;

   public void StartButton(int index)
    {
        SceneManager.LoadScene(sceneBuildIndex: index, LoadSceneMode.Single);
    }

    public void PauseButton()
    {
        optionPanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        optionPanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void OptionsButton()
    {
        optionPanel.SetActive(true);
        optionTint.SetActive(true);
    }

    public void OptionsBackButton()
    {
        optionPanel.SetActive(false);
        optionTint.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}