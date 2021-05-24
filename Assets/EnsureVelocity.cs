using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnsureVelocity : MonoBehaviour
{
    private float initialSpeed;
    private Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        initialSpeed = rigidbody.velocity.magnitude;
        Debug.Log("Speed is = " + initialSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var curSpeed = rigidbody.velocity.magnitude;
        if( Mathf.Abs( curSpeed - initialSpeed ) > 0.1f )
        {
            rigidbody.velocity = rigidbody.velocity / curSpeed * initialSpeed;
        }
    }
}
