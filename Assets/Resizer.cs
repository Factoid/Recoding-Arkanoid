using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour
{ 
    public void Grow( GameObject obj )
    {
        obj.GetComponent<ScaleAdjuster>()?.Grow();
    }

    public void Shrink(GameObject obj)
    {
        obj.GetComponent<ScaleAdjuster>()?.Shrink();
    }

    public void Restore(GameObject obj)
    {
        obj.GetComponent<ScaleAdjuster>()?.Restore();
    }
}
