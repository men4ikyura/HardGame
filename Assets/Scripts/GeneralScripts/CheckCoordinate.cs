using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCoordinate : MonoBehaviour
{
    public ControllText controll;
    void Update()
    {
        if (transform.position.y < -4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            controll.ControllScore();
        }
    }
}
