using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionsMove : MonoBehaviour
{
    public int moveSpeed = 10;

    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {

        //transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        rb.velocity = transform.forward * -1 * moveSpeed * Time.fixedDeltaTime;
    }
}
