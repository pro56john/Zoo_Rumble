using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoins : MonoBehaviour
{
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)

    {

        if (other.gameObject.CompareTag("Player"))

        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
        }


    }
}
