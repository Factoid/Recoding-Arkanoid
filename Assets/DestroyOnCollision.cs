using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionExit2D( Collision2D collision )
    {
        Destroy(gameObject);
    }
}
