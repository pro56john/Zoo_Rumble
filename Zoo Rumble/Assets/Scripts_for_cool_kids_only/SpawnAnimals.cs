using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int j = 0;
    private bool LowDistance = false;
    private int animalIndex;
    private int test = 1;
    private float SpawnRangeX = 117;
    private float SpawnRangeZoffset = 500;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float xnew;
    private float znew;
    private Vector3 spawnPos;
    private double PrefabDistance;
    private float Distance = 50;
    private Vector3 positionBeginning;
    private Vector3 PrefabPosition;
    public float playerZ;
    public GameObject player;

    private GameObject[] _elephantClones;

    private GameObject[] ElephantClones 
    { 
        get => _elephantClones; 
        set => _elephantClones = value; 
    }


    // Start is called before the first frame update
    void Start()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX),
        0, Random.Range(playerZ + 100f, playerZ + SpawnRangeZoffset));
        ElephantClones[0] = Instantiate(animalPrefabs[animalIndex], spawnPos, //needs to be looked at
               animalPrefabs[animalIndex].transform.rotation);
        player.transform.position = positionBeginning;
        positionBeginning.z = playerZ;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        playerZ = player.transform.position.z;

    }
    void SpawnRandomAnimal()
    {
        
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            spawnPos = new Vector3 (Random.Range(-SpawnRangeX, SpawnRangeX),
            0, Random.Range(playerZ + 100f, playerZ + SpawnRangeZoffset));
            xnew = spawnPos.x;
            znew = spawnPos.z;
        
            LowDistance = PrefabsDistance(xnew, znew, Distance, j);
            if (LowDistance == false)
            {
            ElephantClones[j] = Instantiate(animalPrefabs[animalIndex], spawnPos,
               animalPrefabs[animalIndex].transform.rotation);
            j = j + 1;
                Debug.Log(j);
            }


    }
    private bool PrefabsDistance(float x, float z, double D, int Index)
    {
    bool LowDistance = false;
    test = 1;
    for(int i = 0; i <= Index; i++)
        {
            Debug.Log(Index);
        PrefabPosition.x = ElephantClones[i].transform.position.x;
        PrefabPosition.z = ElephantClones[i].transform.position.z;
        PrefabDistance = Mathf.Sqrt(Mathf.Pow(PrefabPosition.x - x,2) + Mathf.Pow(PrefabPosition.z - z,2));
            Debug.Log(PrefabDistance);
        if(PrefabDistance <= Distance)
        {
        test = test * 0;    
        }
        }
    if (test == 0)
    { LowDistance = true; }
       Debug.Log(test);
        Debug.Log(LowDistance);
    return LowDistance;
    }
    
}
