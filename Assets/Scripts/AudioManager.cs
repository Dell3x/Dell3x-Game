using System;
using System.Collections;
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
    private void Start()
    {
        StartCoroutine(LoadSoundsVolume());
    }

    private IEnumerator LoadSoundsVolume()
    {
        yield return new WaitForSeconds(0f);
        SaveSystem.Instance.LoadSound();
    }
    public void PlayClickSound()
    {
        clickSound.pitch = Random.Range(0.9f, 1.1f);
        clickSound.Play();
    }
    
    public AudioMixerGroup SfxMixer
    {
        get => sfxMixer; 
        set => sfxMixer = value; 
    }

    public AudioMixerGroup MusicMixer
    {
        get => musicMixer;
        set => musicMixer = value;
    }
}