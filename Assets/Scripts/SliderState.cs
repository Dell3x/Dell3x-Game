using System;
using System.Collections;
using System.Collections.Generic;
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
        musicSlider.value = AudioManager.instance.musicVolume;
        sfxSlider.value = AudioManager.instance.sfxVolume;
    }
    
    public void ChangeVFXVol()
    {
        AudioManager.instance.sfxVolume = sfxSlider.value;
        AudioManager.instance.SFXMixer.audioMixer.SetFloat("sfxVol", sfxSlider.value);
    }
}