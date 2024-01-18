using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float move, moveSpeed;
    public bool isOnGround = true;  
    public bool gameOver = false;
    private Animator playerAnim;
    private BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))

        {

            this.transform.Translate(new Vector3(0f, 0f, 40f) * Time.deltaTime, Space.Self);

        }

        if (Input.GetKey(KeyCode.RightArrow))

        {

            this.transform.Translate(new Vector3(0f, 0f, -40f) * Time.deltaTime, Space.Self);

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
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_A",true);
            

        }
    }
}