using UnityEngine;

public class ModelScore : MonoBehaviour
{
    public static int score = 5;
    public static void ReduceScore() =>  score -= 1;
}
