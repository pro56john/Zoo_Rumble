using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float move, moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
    }
    private void LateUpdate()
    {
        transform.Translate(0f, 0f, move);
    }
    
}
