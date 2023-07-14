using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManaging : MonoBehaviour
{
    public Toggle musicEffect;
    public List<AudioSource> musicAudioSources = new List<AudioSource>();
	
    private void Start()
    {
        CheckCreateMusicSave();
		
        bool isMusic = (PlayerPrefs.GetInt("music") == 1);
        musicEffect.isOn = isMusic;
        musicEffect.onValueChanged.AddListener((bool val) => MusicBool(val));

        ToggleOnValueChange();
    }
	
    private void ToggleOnValueChange()
    {
        bool musicEnable = PlayerPrefs.GetInt("music") > 0;
        if (musicEnable)
        {
            PlayMusic();
        }
        else
        {
            PauseMusic();
        }
    }

    private void PlayMusic()
    {
        foreach (AudioSource musicAudioSource in musicAudioSources)
        {
            musicAudioSource.Play();
        }
    }

    private void PauseMusic()
    {
        foreach (AudioSource musicAudioSource in musicAudioSources)
        {
            musicAudioSource.Pause();
        }
    }

    private void CheckCreateMusicSave()
    {
        if (PlayerPrefs.HasKey("music"))
            return;
		
        PlayerPrefs.SetInt("music", 1);
    }

    private void MusicBool(bool value)
    {
        PlayerPrefs.SetInt("music", value ? 1 : 0);
        ToggleOnValueChange();
    }
}