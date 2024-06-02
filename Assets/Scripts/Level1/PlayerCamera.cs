using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;

    void Update() =>  transform.position = new Vector3(target.position.x, target.position.y + 10f, target.position.z - 10f);
}

