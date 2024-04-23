using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int score;
    [SerializeField] private float defaultTimeScale;
    [SerializeField] private UI_Controller uI_Controller;
    [SerializeField] private TextMeshProUGUI bestScore;

    private void Start()
    {
        score = 0;
        Time.timeScale = defaultTimeScale;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        CheckBestScore();
        SetScoreText();
        uI_Controller.ShowGameOverButtons();
    }

    public void AddPoint()
    {
        score += 1;
        uI_Controller.UpdateScoreText(score.ToString());
    }

    public void RestartScene()
    {
        PlayerController.IsDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    private void CheckBestScore()
    {
        if (score > Save_Controller.GetBestScore())
            Save_Controller.SaveBestScore(score);
    }

    private void SetScoreText()
    {
        bestScore.text = $"BEST: {Save_Controller.GetBestScore()}";
    }
}
