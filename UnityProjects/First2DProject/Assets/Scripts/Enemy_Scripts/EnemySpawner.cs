using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public GameObject bigEnemyToSpawn;

    public float spawnTime;
    public float spawnTimeRandom;

    private float SpawnTimer;

    // Use this for initialization
    void Start()
    {
        ResetSpawnTimer();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= Time.deltaTime;
        int number = Random.Range(0, 10);

        if (SpawnTimer <= 0.0f && number < 8)
        {
            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            ResetSpawnTimer();
        }
        else if(SpawnTimer <= 0.0f && number >= 8)
        {
            Instantiate(bigEnemyToSpawn, transform.position, Quaternion.identity);
            ResetSpawnTimer();
        }
    }

    void ResetSpawnTimer()
    {
        SpawnTimer = (float)(spawnTime + Random.Range(0, spawnTimeRandom * 100) / 100.0);
    }
}
