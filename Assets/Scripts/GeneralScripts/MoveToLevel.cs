using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevell: MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
