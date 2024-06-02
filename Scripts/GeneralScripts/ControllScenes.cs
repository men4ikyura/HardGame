using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private bool isPaused = false; 

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Application.targetFrameRate = 120;
        ModelScore.score = 5;
        Time.timeScale = 1f;
    }

    public void ExitGame() =>  Application.Quit();
    public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
    
    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void ComebackToMainMenu() => SceneManager.LoadScene(0);
    public bool IsPaused() => isPaused;
}