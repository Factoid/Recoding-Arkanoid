using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnDestroy : MonoBehaviour
{
    public GameObjectEvent OnDestroyed;

    private void OnDestroy()
    {
        if (!gameObject.scene.isLoaded) return;

        OnDestroyed?.Invoke(gameObject);
    }

}
