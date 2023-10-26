using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    public void IncreaseScore(int amount) // Increases score by an amount
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // Decreases score by an amount
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // Updates score UI text
    {
        scoreText.text = "Score: " + score;
    }
}
