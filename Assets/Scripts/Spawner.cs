using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject objectToSpawn;
    public int numberOfEnemies;
    private float SpawnRadius = 20;
    private Vector3 spawnPosition;

	void Start () {
        StartCoroutine(Timer());
    }
	
	

    void SpawnBasicEnemies()
    {
        for(int i =0; i< numberOfEnemies; i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * SpawnRadius;
            Vector3 adjustedSpawn = new Vector3(spawnPosition.x, 1, spawnPosition.z);
            Instantiate(objectToSpawn, adjustedSpawn, Quaternion.identity);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        SpawnBasicEnemies();
        yield return new WaitForSeconds(60);
        SpawnBasicEnemies();
    }
}
