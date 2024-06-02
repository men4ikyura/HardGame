using UnityEngine;
using UnityEngine.UI;

public class ViewScore : MonoBehaviour
{
    public Text scoreText;
    
    private void Start() =>  UpdateScoreUI();
    
    public void UpdateScoreUI() =>  scoreText.text = "Количество оставшихся попыток: " + ModelScore.score;

    public void OnClickReduceScore()
    {
        ModelScore.ReduceScore();
        UpdateScoreUI();
    }
}
