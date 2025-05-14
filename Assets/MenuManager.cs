using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource backgroundMusic; 
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        if (backgroundMusic != null)
        {
            backgroundMusic.Stop();
        }

        SceneManager.LoadScene("MainMenu"); 
        }
}
