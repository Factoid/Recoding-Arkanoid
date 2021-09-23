using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnableComponents : MonoBehaviour
{
    [SerializeField]
    private List<string> typesToEnable = new List<string>();

    public void EnableTypes( GameObject obj )
    {
        SetEnable(obj, true);
    }

    public void DisableTypes( GameObject obj )
    {
        SetEnable(obj, false);
    }

    private void SetEnable( GameObject obj, bool value )
    {
        foreach( var tstr in typesToEnable )
        {
            var type = Type.GetType(tstr);
            if (type == null)
            {
                Debug.LogWarning(tstr + " is not a known type in this namespace");
                continue;
            }

            foreach( var comp in obj.GetComponentsInChildren(type,true) )
            {
                if (comp is Behaviour b) b.enabled = value;
            }
        }
    }
}
