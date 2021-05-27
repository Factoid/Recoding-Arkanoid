using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdjuster : MonoBehaviour
{
    [SerializeField]
    private int value;

    public ScoreManager ScoreManager { get; set; }

    public void AdjustValue()
    {
        ScoreManager.Score += value;
    }
}
