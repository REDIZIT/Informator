using InApp;
using System;
using UnityEngine;

public class KeyBinder : MonoBehaviour
{
    public static Action<Keys> onKeyPressed;

    private void Start()
    {
        InterceptKeys.SetHook(onKeyPressed);
    }
    private void OnDestroy()
    {
        InterceptKeys.RemoveHook();
    }
}