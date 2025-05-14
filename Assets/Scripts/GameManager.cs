using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI timerText;
    public float timeRemaining = 30f;
    private bool isGameActive = true;

    void Update()
    {
        if (isGameActive)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(timeRemaining).ToString();

            if (timeRemaining <= 0)
            {
                GameOver(false); 
            }
        }
    }

  public void GameOver(bool didWin = false)
{
    isGameActive = false;
    gameOverPanel.SetActive(true);
    Time.timeScale = 0f;
    resultText.text = didWin ? "YOU WIN!" : "GAME OVER";

    if (didWin)
    {
        SoundManager.instance.PlayWinSound();
    }
    else
    {
        SoundManager.instance.PlayFailSound();
    }

    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
