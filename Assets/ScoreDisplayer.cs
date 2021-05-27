using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro textMesh;

    public void ScoreChanged( ScoreManager manager )
    {
        textMesh.text = "Score : " + manager.Score;
    }
}
