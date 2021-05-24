using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [SerializeField]
    private int initialLives;
    private int currentLives;

    public event System.Action LifeLost;
    public event System.Action GameOver;

    public void LoseLife()
    {
        currentLives -= 1;
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
        currentLives = initialLives;
    }

    private void OnGUI()
    {
        GUILayout.Space(20);
        GUILayout.Label("Lives = " + currentLives);
    }
}
