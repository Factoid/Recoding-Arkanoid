using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseLifeOnTrigger : MonoBehaviour
{
    [SerializeField]
    private LivesManager livesManager;

    private void OnTriggerEnter2D( Collider2D collider )
    {
        livesManager.LoseLife();
    }
}
