using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckOnCollision2 : MonoBehaviour
{
    public ControllText controller;
    private Rigidbody rb;
    
    void Start() => rb = GetComponent<Rigidbody>();
  
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            controller.ControllScore();
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Triger"))
            transform.localScale += new Vector3(0.1f,0.1f,0.1f);

        if (collision.gameObject.CompareTag("NotTriger"))
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);

        if (collision.gameObject.CompareTag("Accelerator"))
            rb.AddForce(transform.forward * 500f, ForceMode.Acceleration);
    }
}
