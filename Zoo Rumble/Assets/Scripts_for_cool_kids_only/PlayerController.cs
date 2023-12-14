using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float move, moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))

        {

            this.transform.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime, Space.Self);

        }

        if (Input.GetKey(KeyCode.RightArrow))

        {

            this.transform.Translate(new Vector3(0f, 0f, -10f) * Time.deltaTime, Space.Self);

        }

    }
}