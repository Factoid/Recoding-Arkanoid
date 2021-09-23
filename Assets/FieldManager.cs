using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FieldManager : MonoBehaviour
{
    private HashSet<GameObject> bricks = new HashSet<GameObject>();
    [SerializeField]
    private UnityEvent FieldCleared;

    public void BrickSpawned(GameObject brick)
    {
        bricks.Add(brick);
        var cmp = brick.GetComponent<EventOnDestroy>();
        if( cmp != null )
        {
            cmp.OnDestroyed.AddListener(BrickDestroyed);
        }
    }

    public void BrickDestroyed(GameObject brick)
    {
        bricks.Remove(brick);
        if( bricks.Count == 0 )
        {
            FieldCleared?.Invoke();
        }
    }
}
