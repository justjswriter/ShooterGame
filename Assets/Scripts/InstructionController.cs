using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsController : MonoBehaviour
{
       public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");  }
}
