using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    public float gravityScale = 0.3f; // setG
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // close auto G
    }

    void FixedUpdate()
    {
        Vector3 customGravity = new Vector3(0, -9.81f * gravityScale, 0);
        rb.AddForce(customGravity, ForceMode.Acceleration);
    }
}