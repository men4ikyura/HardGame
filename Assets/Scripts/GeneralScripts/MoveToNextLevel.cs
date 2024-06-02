using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public GameObject plane;
    private float _limitCoordinate;
    
    public float LimitCoordinate {
        get => _limitCoordinate;
        set => _limitCoordinate = value;
    }
    
    void Start() =>  LimitCoordinate = plane.transform.localScale.z / 2 * 10;
    
    void Update()
    {
        if (transform.position.z < LimitCoordinate && transform.position.z > LimitCoordinate - 1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
