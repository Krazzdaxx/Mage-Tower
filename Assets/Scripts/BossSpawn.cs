using UnityEngine;
using System.Collections;

public class BossSpawn : MonoBehaviour
{
    public GameObject boss;
    void Start()
    {
        StartCoroutine(SpawnBoss());
    }

    IEnumerator SpawnBoss()
    {
        yield return new WaitForSeconds(30);
        Instantiate(boss, transform.position, transform.rotation);
        yield return new WaitForSeconds(90);
        Instantiate(boss, transform.position, transform.rotation);
    }

}