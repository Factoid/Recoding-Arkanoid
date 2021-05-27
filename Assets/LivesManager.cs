using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class LivesEvent : UnityEvent<LivesManager>
{
}

public class LivesManager : MonoBehaviour
{
    [SerializeField]
    private int initialLives;
    private int currentLives;

    [SerializeField]

    public int Lives
    {
        get { return currentLives; }
        private set {
            bool changed = currentLives != value;
            currentLives = value;
            if (changed) LivesChanged?.Invoke(this);
        }
    }

    [SerializeField]
    private LivesEvent LivesChanged;
    [SerializeField]
    private UnityEvent LifeLost;
    [SerializeField]
    private UnityEvent GameOver;

    public void LoseLife()
    {
        Lives -= 1;
        if( currentLives <= 0 )
        {
            GameOver?.Invoke();
        } else
        {
            LifeLost?.Invoke();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Lives = initialLives;
    }
}
