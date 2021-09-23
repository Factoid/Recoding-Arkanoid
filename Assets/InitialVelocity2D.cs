using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class InitialVelocity2D : MonoBehaviour
{
    [SerializeField]
    private Vector2 initialVelocity;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = initialVelocity;
    }
}
