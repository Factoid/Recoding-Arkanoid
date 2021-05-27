using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class ScoreEvent : UnityEvent<ScoreManager>
{
}

public class ScoreManager : MonoBehaviour
{
    private int currentScore = int.MaxValue;

    [SerializeField]

    public int Score
    {
        get { return currentScore; }
        set
        {
            bool changed = currentScore != value;
            currentScore = value;
            if (changed) ScoreChanged?.Invoke(this);
        }
    }

    private void Start()
    {
        Score = 0;
    }

    public void BrickSpawned( GameObject brick )
    {
        var adjuster = brick.GetComponent<ScoreAdjuster>();
        if (adjuster == null) return;
        adjuster.ScoreManager = this;
    }

    [SerializeField]
    private ScoreEvent ScoreChanged;
}
