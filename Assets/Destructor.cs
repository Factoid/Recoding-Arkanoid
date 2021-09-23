using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    [SerializeField]
    private List<string> tagsToIgnore = new List<string>();

    public void Destruct()
    {
        Destroy(gameObject);
    }

    public void DestructOther( GameObject obj )
    {
        if (tagsToIgnore.Contains(obj.tag)) return;

        Destroy(obj);
    }
}
