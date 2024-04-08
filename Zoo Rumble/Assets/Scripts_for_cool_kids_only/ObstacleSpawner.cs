using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private int initAmount = 5;
    private int spawnInterval = 250; // Where does the spawning begin
    private int lastSpawnZ = 150;
    private int SpawnAmount = 2;

    public List<GameObject> obstacles;
    public GameObject coins;
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnObstacles();
        }
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
            if (Random.Range(0, 3) == 0) // Wie often man ein Obstacle spawnt
            {
                GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];

                Instantiate(obstacle, new Vector3(Random.Range(-100,100), 0.25f, lastSpawnZ), obstacle.transform.rotation); 
            }
        }
    }
}