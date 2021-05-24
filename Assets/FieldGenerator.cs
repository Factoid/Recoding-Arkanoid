using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour
{
    [SerializeField]
    private int rows;
    [SerializeField]
    private int columns;
    [SerializeField]
    private GameObject prefab;

    // Start is called before the first frame update
    void Awake()
    {
        for (int x = 0; x < columns; ++x)
        {
            for( int y = 0; y < rows; ++y )
            {
                var brick = Instantiate(prefab);
                var renderer = brick.GetComponent<Renderer>();
                brick.transform.position = transform.position + (Vector3.right * renderer.bounds.size.x * x) + (Vector3.down * renderer.bounds.size.y * y);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int x = 0; x < columns; ++x)
        {
            for (int y = 0; y < rows; ++y)
            {
                var renderer = prefab.GetComponent<Renderer>();
                var pos = transform.position + (Vector3.right * renderer.bounds.size.x * x) + (Vector3.down * renderer.bounds.size.y * y);
                Gizmos.DrawWireCube(pos, renderer.bounds.size);
            }
        }
    }
}
