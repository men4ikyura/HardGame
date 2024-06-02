using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision : MonoBehaviour
{
    public ControllEffect controllerEffect;
    public ControllText controllerText;
    public bool IsProtected = false;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube") && !IsProtected)
        {
            controllerText.ControllScore();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.CompareTag("Accelerator"))
            controllerEffect.ControllEfect(); 
    }
}

