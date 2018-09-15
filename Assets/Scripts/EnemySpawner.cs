using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyContainer;
    public GameObject iceCubePrefab;

    public float spawnDelay = 3f;
    public float spawnDelayVariance = 1f;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while(true)
        {
            // create a new ice cube
            GameObject newEnemy = GameObject.Instantiate(iceCubePrefab, transform.position, transform.rotation);
            newEnemy.transform.SetParent(enemyContainer.transform);

            yield return new WaitForSeconds(spawnDelay + Random.Range(-spawnDelayVariance, spawnDelayVariance));
        }
    }
}
