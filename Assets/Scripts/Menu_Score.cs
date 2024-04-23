using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu_Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestScore;

    private void Start()
    {
        bestScore.text = $"BEST SCORE: {Save_Controller.GetBestScore()}";
    }
}
