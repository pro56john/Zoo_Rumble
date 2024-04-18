using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound; // Variablen fuer den Code
    private Vector3 positionBeginning; // Variablen fuer den Code (speziell fuer eine Nummer)
    public float playerZ; // Variablen fuer den Code
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); // Es sucht und findet den Spieler 
        positionBeginning = player.transform.position; // Es sucht nach der Spieler position
    }

    // Update is called once per frame
    void Update()
    {
        playerZ = player.transform.position.z; 
        lowerBound = playerZ - 20f; // Dies erstellt eine Boundrie dies sich mit dem Spieler bewegt
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject); // Dies zersoert die Objekten die ausserhalb von der Boundrie gehen
        }
    }
}
