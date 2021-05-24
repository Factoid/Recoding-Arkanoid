using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        transform.position = pos;
    }
}
