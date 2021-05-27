using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LivesDisplayer : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro textMesh;

    public void LivesChanged( LivesManager manager )
    {
        textMesh.text = "Lives : " + manager.Lives;
    }
}
