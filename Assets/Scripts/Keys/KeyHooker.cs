using InApp;
using System;
using System.IO;
using UnityEngine;

public class KeyHooker : MonoBehaviour
{
    public KeysBindings bindings = new KeysBindings();
    public Action<Keys> onKeyPressed;

    private Action<Keys> keyChangeCallback;

#if UNITY_EDITOR
    public static string Filepath => Application.dataPath + "/../Build/keyboard_settings.json";
#else
    public static string Filepath => Application.dataPath + "/../keyboard_settings.json";
#endif

    private void Awake()
    {
        Load();
        InterceptKeys.SetHook(OnKeyPressed);
    }
    private void OnDestroy()
    {
        InterceptKeys.RemoveHook();
    }

    public void Load()
    {
        if (File.Exists(Filepath) == false)
        {
            Save();
        }

        string json = File.ReadAllText(Filepath);
        JsonUtility.FromJsonOverwrite(json, bindings);
    }
    public void Save()
    {
        string json = JsonUtility.ToJson(bindings, true);
        File.WriteAllText(Filepath, json);
    }
    public void InvokeKeyChanging(Action<Keys> callback)
    {
        keyChangeCallback = callback;
    }
    private void OnKeyPressed(Keys key)
    {
        if (keyChangeCallback != null)
        {
            keyChangeCallback(key);
            keyChangeCallback = null;
        }
        else
        {
            onKeyPressed?.Invoke(key);
        }
    }
}
