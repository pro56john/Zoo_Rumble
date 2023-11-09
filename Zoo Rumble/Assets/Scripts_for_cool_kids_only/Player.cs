using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject target = null;
    public float snapDistance = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        if (Vector3.Distance(transform.position, target.transform.position)<= snapDistance) 
        {
            target.transform.parent = transform;
            target.transform.localRotation = Quaternion.identity;
        }
    }
}
