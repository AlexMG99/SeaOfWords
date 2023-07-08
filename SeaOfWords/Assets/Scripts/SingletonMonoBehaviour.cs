using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour
{
    private static T _instance;

    public static T Instance => _instance;

   virtual protected void Awake()
    {
        if(_instance == null)
        {
            _instance = GetComponent<T>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
