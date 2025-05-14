using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
        UpdateScore();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
