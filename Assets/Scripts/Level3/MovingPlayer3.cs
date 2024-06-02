using UnityEngine;

public class MovingPlayer3: MonoBehaviour
{
    public float speed;

    private float MoveHorizontal { get; set; }
    private float MoveVertival { get; set; }

    void Start()
    {
        MoveHorizontal = 0f;
        MoveVertival = 0f;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveHorizontal = 1f;
            MoveVertival = 0f;
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MoveHorizontal = -1f;
            MoveVertival = 0f;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            MoveHorizontal = 0f;
            MoveVertival = -1f;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveHorizontal = 0f;
            MoveVertival = 1f;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        var movement = new Vector3(MoveHorizontal * 0.1f * Time.timeScale, 0f, MoveVertival * speed * Time.timeScale);
        transform.position += movement;
    }
}