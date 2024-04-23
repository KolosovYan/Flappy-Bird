using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    private string difficulty;
    private float volume;

    public void SaveVolumeSettings(float volume)
    {
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void SaveDifficultyLevel(string diff)
    {
        PlayerPrefs.SetString("Difficulty", diff);
    }

    public float LoadVolumeSettings()
    {
        return volume = PlayerPrefs.GetFloat("Volume") == 0 ? 0.5f : PlayerPrefs.GetFloat("Volume");
    }

    public string LoadDifficultyLevel()
    {
        return difficulty = PlayerPrefs.GetString("Difficulty") == "" ? "MediumLevel" : PlayerPrefs.GetString("Difficulty");
    }
}
