using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAdjuster : MonoBehaviour
{
    [SerializeField]
    private Vector3 grownScale;
    [SerializeField]
    private Vector3 shrunkScale;
    [SerializeField]
    private Vector3 normalScale;

    public void Grow()
    {
        transform.localScale = grownScale;       
    }

    public void Shrink()
    {
        transform.localScale = shrunkScale;
    }

    public void Restore()
    {
        transform.localScale = normalScale;
    }
}
