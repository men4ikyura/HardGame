using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision3 : MonoBehaviour
{
    public ControllText controller;
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Triger"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            controller.ControllScore();
        }
    }
}
