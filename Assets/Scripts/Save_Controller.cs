using UnityEngine;

public class Save_Controller 
{
    public static void SaveBestScore(int score) => PlayerPrefs.SetInt("BestScore", score);

    public static int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore");
    }
}
