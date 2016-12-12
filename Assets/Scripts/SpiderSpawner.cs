using UnityEngine;
using System.Collections;

public class SpiderSpawner : MonoBehaviour
{
    public GameObject spiderPrefab;
    public int numberOfEnemies = 5;

    private float spawnRadius = 5;
    private Vector3 spawnPosition;

    void Start()
    {
        StartCoroutine(Timer());
    }

    void SpawnSpiders()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            Vector3 adjustedSpawn = new Vector3(spawnPosition.x, 1, spawnPosition.z);
            Instantiate(spiderPrefab, adjustedSpawn, Quaternion.identity);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10);
        SpawnSpiders();
        yield return new WaitForSeconds(70);
        SpawnSpiders();
    }
}
