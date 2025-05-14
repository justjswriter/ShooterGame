using UnityEngine;
using UnityEngine.SceneManagement; 
public class MenuController : MonoBehaviour
{
       public void StartGame()
    {
        SceneManager.LoadScene("MainScene");   }

       public void ShowInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

       public void QuitGame()
    {
        Application.Quit();
    }
}
