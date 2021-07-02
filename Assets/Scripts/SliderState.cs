using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderState : MonoBehaviour
{
    public static SliderState instance;

    public Slider musicSlider;
    public Slider sfxSlider;

    private void Awake()
    {
        instance = this;
    }

    public void CheckSlidersValue()
    {
        musicSlider.value = AudioManager.instance.musicVolume;
        sfxSlider.value = AudioManager.instance.sfxVolume;
    }
    
    public void ChangeVFXVol()
    {
        AudioManager.instance.sfxVolume = SliderState.instance.sfxSlider.value;
        AudioManager.instance.SFXMixer.audioMixer.SetFloat("sfxVol", SliderState.instance.sfxSlider.value);
    }
}