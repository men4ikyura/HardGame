using UnityEngine;
using System.Collections;


public class CubeSpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject[] spawnObjects;
    public float timeSpawn;

    void Start() => StartCoroutine(Spawn());
  
    IEnumerator Spawn()
    {
       while(true)
       {
           yield return new WaitForSeconds(timeSpawn);
           var choiceSpawn = Random.Range(0, spawnPoint.Length);
           var currentSpawner = spawnPoint[choiceSpawn];
           var spawnArea = currentSpawner.position + new Vector3(0,0, Random.Range(-46, 48));
           Instantiate(spawnObjects[choiceSpawn], spawnArea, currentSpawner.rotation);
       } 
    }
}
