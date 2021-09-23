using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectSpawner : MonoBehaviour
{
    [System.Serializable]
    public struct Entry
    {
        public int weight;
        public GameObject prefab;
        public Transform spawnPoint;
    }

    [SerializeField]
    private List<Entry> entries = new List<Entry>();

    private int maxWeight;

    private void Awake()
    {
        maxWeight = entries.Sum(x => x.weight);
    }

    public void Spawn()
    {
        var roll = Random.Range(0, maxWeight);
        var entry = entries.FirstOrDefault(x => { var val = roll < x.weight; roll -= x.weight; return val; });
        if (entry.prefab == null) return;

        var go = Instantiate(entry.prefab);
        if (entry.spawnPoint)
        {
            go.transform.position = entry.spawnPoint.position;
        }
    }    
}
