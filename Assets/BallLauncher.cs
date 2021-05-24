using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField]
    private FireBall ball;

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown("Fire1") )
        {
            ball.enabled = true;
            enabled = false;
        }        
    }
}
