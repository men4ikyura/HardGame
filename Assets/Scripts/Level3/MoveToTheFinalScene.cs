using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToTheFinalScene : MonoBehaviour
{
    void Update()
    {
        if (transform.position.z > 28f)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
