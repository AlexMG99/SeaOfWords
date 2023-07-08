using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : SingletonMonoBehaviour<InputManager>
{
    public static T PerformRaycast<T>(string layerTag, float raycastDistance = Mathf.Infinity)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, LayerMask.GetMask(layerTag)))
        {
            return hit.collider.GetComponent<T>();
        }

        return default(T);
    }

    public static Vector2 GetMousePosition()
    {
#if UNITY_EDITOR
        return Input.mousePosition;
#elif UNITY_ANDROID
        return Input.touchCount > 0 ? Input.GetTouch(0).position : Vector2.zero;
#endif

    }
}
