using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float frontLimit = 30;
    private float sideLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < -frontLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < sideLimit)
        {
            Destroy(gameObject);
        }

    }
}