using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TestCharControler : MonoBehaviour
{
    public SpawnManager spawnManager;
    private float move, moveSpeed;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    private BoxCollider boxCollider;
    private float speed = 150f;
    public Text uiCoin;
    private int coins = 0;
    public GameObject player;


    // Start is called before the first frame update 
    public GameOverScript GameOverScript;

    void Start()

    {
        player = GameObject.Find("Player");

        playerAnim = GetComponent<Animator>();

        boxCollider = GetComponent<BoxCollider>();

    }
    // Update is called once per frame 

    void Update()

    {
        if (gameOver == false)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {

                this.transform.Translate(new Vector3(0f, 0f, 80f) * Time.deltaTime, Space.Self);



            }


            speed = speed + 0.1f;
            transform.Translate(Vector3.right * speed * Time.deltaTime);


            if (Input.GetKey(KeyCode.RightArrow))



            {



                this.transform.Translate(new Vector3(0f, 0f, -80f) * Time.deltaTime, Space.Self);

            }
        }
        
        uiCoin.text = "coins: " + coins.ToString();
        
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
            GameOverScript.Setup(0);
            Debug.Log("Game Over!");

            playerAnim.SetBool("Death_A", true);

            speed = 0;
        }
        if (other.gameObject.CompareTag("Coin"))
        {

            coins = coins + 1;

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
    
}
