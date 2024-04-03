using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound;
    private Vector3 positionBeginning;
    public float playerZ;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        positionBeginning = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerZ = player.transform.position.z;
        lowerBound = playerZ - 20f;
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
