using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    [SerializeField]
    private FireBall ball;

    private Vector3 initialLocalPosition;

    private void Awake()
    {
        
    }

    private void Start()
    {
        initialLocalPosition = ball.gameObject.transform.localPosition;
        ResetBall();
    }

    public void ResetBall() {
        enabled = true;
        ball.Stick(transform, initialLocalPosition);
    }


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
