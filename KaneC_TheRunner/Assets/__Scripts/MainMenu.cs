using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    [Header("Settings")]
    public Slider sensitivitySlider;
    public Slider musicSlider;
    public Slider soundSlider;
    public Toggle invertToggle;
    public AudioSource musicPlayer;

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        soundSlider = GameObject.Find("SoundSlider").GetComponent<Slider>();
        sensitivitySlider = GameObject.Find("SensitivitySlider").GetComponent<Slider>();
        musicSlider = GameObject.Find("MusicSlider").GetComponent<Slider>();
        invertToggle = GameObject.Find("InvertToggle").GetComponent<Toggle>();

        SetPlayerPrefs();
    }
    public void SetPlayerPrefs()
    {
        if (!PlayerPrefs.HasKey("MouseSensitivity"))
        {
            PlayerPrefs.SetFloat("MouseSensitivity", sensitivitySlider.value);
        }
        else
        {
            sensitivitySlider.value = PlayerPrefs.GetFloat("MouseSensitivity");
        }
        
        if (!PlayerPrefs.HasKey("InvertMouse"))
        {
            if (invertToggle.isOn)
            {
                PlayerPrefs.SetInt("InvertMouse", 1);
            }
            else
            {
                PlayerPrefs.SetInt("InvertMouse", 0);
            }
        }
        else
        {
            if(PlayerPrefs.GetInt("InvertMouse") == 1)
            {
                invertToggle.isOn = true;
            }
            else
            {
                invertToggle.isOn = false;
            }
        }
        
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
        }
        else
        {
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        }

        musicPlayer.volume = PlayerPrefs.GetFloat("MusicVolume");

        if (!PlayerPrefs.HasKey("SoundVolume"))
        {
            PlayerPrefs.SetFloat("SoundVolume", soundSlider.value);
        }
        else
        {
            soundSlider.value = PlayerPrefs.GetFloat("SoundVolume");
        }
    }

    public void UpdateMusicSlider(float newValue)
    {
        PlayerPrefs.SetFloat("MusicVolume", newValue);
        musicPlayer.volume = newValue;
    }

    public void UpdateSoundSlider(float newValue)
    {
        PlayerPrefs.SetFloat("SoundVolume", newValue);
    }

    public void UpdateSensitivitySlider(float newValue)
    {
        PlayerPrefs.SetFloat("MouseSensitivity", newValue);
    }

    public void UpdateInvertToggle()
    {
        if (invertToggle.isOn)
        {
            PlayerPrefs.SetInt("InvertMouse", 1);
        }
        else
        {
            PlayerPrefs.SetInt("InvertMouse", 0);
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene(1);
    }
}
