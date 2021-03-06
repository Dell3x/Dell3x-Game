using UnityEngine;
using UnityEngine.UI;

public class SliderState : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;

    private void Start()
    {
        CheckSlidersValue();
    }

    public void CheckSlidersValue()
    {
        musicSlider.value = SaveSystem.Instance.SaveInfo.musicSound;
        sfxSlider.value = SaveSystem.Instance.SaveInfo.sfxSound;
    }

    public void ChangeVFXVol()
    {
        AudioManager.instance.sfxVolume = sfxSlider.value;
        AudioManager.instance.SfxMixer.audioMixer.SetFloat("sfxVol", sfxSlider.value);
    }

    public void ChangeMusicVol()
    {
        AudioManager.instance.musicVolume = musicSlider.value;
        AudioManager.instance.MusicMixer.audioMixer.SetFloat("musicVol", musicSlider.value);
    }
}