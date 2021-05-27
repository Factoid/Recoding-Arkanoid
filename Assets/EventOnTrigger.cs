using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObjectEvent onTriggerEnter;
    [SerializeField]
    private GameObjectEvent onCollisionEnter;

    private void OnTriggerEnter2D( Collider2D collider )
    {
        onTriggerEnter?.Invoke(collider.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollisionEnter?.Invoke(collision.gameObject);
    }
}
