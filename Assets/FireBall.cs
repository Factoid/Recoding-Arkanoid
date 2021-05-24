using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
    private float heading;
    [SerializeField] 
    private float initialSpeed;

    void OnEnable()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Quaternion.Euler(0, 0, heading) * Vector2.right * initialSpeed;
        enabled = false;
    }
}
