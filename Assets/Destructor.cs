using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    public void Destruct()
    {
        Destroy(gameObject);
    }

    public void DestructOther( GameObject obj )
    {
        Destroy(obj);
    }
}
