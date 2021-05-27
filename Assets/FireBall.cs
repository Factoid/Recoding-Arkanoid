using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
    private float heading;
    [SerializeField] 
    private float initialSpeed;

    private new Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Stick( Transform parent, Vector3 pos )
    {
        transform.parent = parent;
        transform.localPosition = pos;
        rigidbody.velocity = Vector2.zero;
        rigidbody.simulated = false;
    }

    void OnEnable()
    {
        rigidbody.velocity = Quaternion.Euler(0, 0, heading) * Vector2.right * initialSpeed;
        rigidbody.simulated = true;
        gameObject.transform.parent = null;
        enabled = false;
    }
}
