using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnClick : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnClick;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            OnClick?.Invoke();
        }
    }
}
