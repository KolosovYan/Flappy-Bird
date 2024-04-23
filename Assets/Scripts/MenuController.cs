using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using AppsFlyerSDK;

public class MenuController : MonoBehaviour
{
    [SerializeField] private SaveLoad saveLoad;
    [SerializeField] private GameObject settingsButtons;
    [SerializeField] private GameObject settingButton;
    [SerializeField] private GameObject startGameButton;
    [SerializeField] private GameObject startButton;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Slider volumeSlider;
    private string currentDifficultyLevel;
    private float volumeLevel;

    private void Awake()
    {
        UpdateDifficultySetting();
        UpdateVolumeSettings();
    }

    public void SetVolumeLevel()
    {
        saveLoad.SaveVolumeSettings(volumeSlider.value);
        audioSource.volume = volumeSlider.value;
    }

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(currentDifficultyLevel);
    }

    public void OnSettingsButtonClick()
    {
        settingsButtons.SetActive(true);
        startGameButton.SetActive(false);
        settingButton.SetActive(false);
    }

    public void OnMenuButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }

    private void UpdateDifficultySetting()
    {
        currentDifficultyLevel = saveLoad.LoadDifficultyLevel();
    }

    private void UpdateVolumeSettings()
    {
        volumeLevel = saveLoad.LoadVolumeSettings();
        volumeSlider.value = volumeLevel;
        audioSource.volume = volumeLevel;
    }

    public void OnEasyButtonClick()
    {
        saveLoad.SaveDifficultyLevel("EasyLevel");
        UpdateDifficultySetting();
    }

    public void OnMediumButtonClick()
    {
        saveLoad.SaveDifficultyLevel("MediumLevel");
        UpdateDifficultySetting();
    }

    public void OnHardButtonClick()
    {
        saveLoad.SaveDifficultyLevel("HardLevel");
        UpdateDifficultySetting();
    }
}
