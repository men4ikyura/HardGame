using UnityEngine;


public class SpawnAccelerator : MonoBehaviour
{
    public GameObject accelerator;
    void Start() => Spawn();

    void Spawn()
    {
        for (var i = 0; i < 5; i++)
        {
            var randomX = Random.Range(-8, 8); 
            var randomZ = Random.Range(-45, 35); 
            var randomPosition = new Vector3(randomX, 0, randomZ);
            Instantiate(accelerator, randomPosition, Quaternion.identity);
        }
    }
}
