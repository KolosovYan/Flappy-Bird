using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject gameOverButtons;

    public void UpdateScoreText(string text)
    {
        scoreText.text = text;
    }

    public void ShowGameOverButtons()
    {
        gameOverButtons.SetActive(true);
    }

    public void OnClickRestart()
    {
        sceneController.RestartScene();
    }

    public void OnClickMenu()
    {
        sceneController.LoadMenuScene();
    }
}
