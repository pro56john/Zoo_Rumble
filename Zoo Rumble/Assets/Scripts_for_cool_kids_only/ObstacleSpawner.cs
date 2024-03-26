using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private int spawnInterval = 250; // Where does the spawning begin
    private int lastSpawnZ = 150;
    private int SpawnAmount = 3;

    public List<GameObject> obstacles;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnObstacles ();
    }
    public void SpawnObstacles()
    {
        lastSpawnZ += spawnInterval;

        for (int i = 0; i < SpawnAmount; i++)
        {
            if (Random.Range(0, 4) == 0)
            {
                GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];

                Instantiate(obstacle, new Vector3(Random.Range(-100,100), 0.25f, lastSpawnZ), obstacle.transform.rotation);
            }
        }
    }
}