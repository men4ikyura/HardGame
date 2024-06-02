using UnityEngine;

public class MovingPlayer: MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal"); 
        var moveVertical = Input.GetAxis("Vertical"); 
        var movement = new Vector3(moveHorizontal * speed * Time.timeScale, 0f, moveVertical * speed * Time.timeScale); 
        transform.position += movement; 
    }
}