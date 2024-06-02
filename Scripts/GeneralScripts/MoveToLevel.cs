using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel: MonoBehaviour
{
    void Update()
    {
        if (Input.anyKey)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
