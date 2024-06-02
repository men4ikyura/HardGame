using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllText : MonoBehaviour
{
    public ViewScore view;

    public void ControllScore()
    {
        view.OnClickReduceScore();
        if (ModelScore.score == 0)
        {
            ModelScore.score = 5;
            SceneManager.LoadScene(1);
        }
    }
}
