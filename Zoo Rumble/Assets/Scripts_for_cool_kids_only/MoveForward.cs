using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 15.0f; 
    public bool isOnGround = true, gameOver = false;
    private BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else if (gameOver == true)
        {
            speed = 0f;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Road"))
        {
            isOnGround = true;

        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            

        }
    }
}
