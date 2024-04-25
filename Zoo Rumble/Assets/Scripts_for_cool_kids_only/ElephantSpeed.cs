using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantSpeed : MonoBehaviour
{
    private float speed; // Variablen für den Code
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(40, 80); // findet eine nummer zwischen 40-80 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime); // Benutzt die Variable somit die Elefanten sich fortbewegen mit der schneligkeit von 40-80
    }
    private void OnCollisionEnter(Collision other)

    {

        

        if (other.gameObject.CompareTag("Obstacle"))

        {

            Destroy(gameObject);
        }
        
    }
}
