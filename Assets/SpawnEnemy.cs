using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    int maxEnemies = 5;
    int spawnedEnemies = 0;
    void Start()
    {
        while (spawnedEnemies < maxEnemies)
        {
            Spawn();
            spawnedEnemies += 1;
        }
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
    }

    private void Update()
    {

    }

    void Spawn()
    {
        int spawnPointX = Random.Range(-23, 23);
        int spawnPointZ = Random.Range(-23, 23);
        Vector3 spawnPosition = new Vector3(spawnPointX, 2, spawnPointZ);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}