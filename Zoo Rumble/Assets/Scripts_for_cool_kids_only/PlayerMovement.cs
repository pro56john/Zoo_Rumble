using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float variableToChange;
    public float changePerSecond;
    public bool useFixedUpdate;
    // Start is called before the first frame update
    void Start()
    {
        variableToChange  = 100;
    }

    // Update is called once per frame


    void Update()
    {

        if (!useFixedUpdate)
        {
            variableToChange = changePerSecond * Time.deltaTime;
        }

        transform.Translate(Vector3.right * variableToChange * Time.deltaTime);

    }
    void FixedUpdate()
    {
        if (!useFixedUpdate)
        {
            variableToChange += changePerSecond * Time.deltaTime;
        }
    }
}
