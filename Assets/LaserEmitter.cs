using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEmitter : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    public List<Transform> spawnPoints;

    public void Shoot()
    {
        foreach( var t in spawnPoints )
        {
            var shot = Instantiate(prefab);
            shot.transform.position = t.position;
        }
    }

}
