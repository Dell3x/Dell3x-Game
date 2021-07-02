using System;
using UnityEngine;
using UnityEngine.Audio;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public float musicVolume;
    public float sfxVolume;

    [SerializeField] private AudioSource clickSound;

    [SerializeField] private AudioMixerGroup musicMixer;
    [SerializeField] private AudioMixerGroup sfxMixer;

    public AudioMixerGroup SFXMixer
    {
        get
        {
            return sfxMixer;
        }

        set
        {
            sfxMixer = value;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlayClickSound()
    {
        clickSound.pitch = Random.Range(0.9f, 1.1f);
        clickSound.Play();
    }

  
}