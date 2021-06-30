using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private AudioSource menuMusic;
    [SerializeField] private AudioSource clickSound;
    
    [Header("Options Panel")]
    [SerializeField] private GameObject optionPanel;
    [SerializeField] private GameObject optionTint;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider vfxSlider;

    [Header("Pause Panel")] 
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject pauseButton;
    

    public void StartButton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1, LoadSceneMode.Single);
    }

    public void PauseButton()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        pausePanel.SetActive(false);
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

    public void PlayClickSound()
    {
        clickSound.Play();
    }
    public void ChangeMusicVol()
    {
        menuMusic.volume = musicSlider.value;
    }

    public void ChangeVFXVol()
    {
        clickSound.volume = vfxSlider.value;
    }

   public void QuitButton()
    {
        Application.Quit();
    }
}
