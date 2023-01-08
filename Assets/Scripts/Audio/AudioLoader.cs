using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AudioLoader : MonoBehaviour
{
    public Dictionary<string, AudioClip> clips = new();

#if UNITY_EDITOR
    public static string Folder => Application.dataPath + "/../Build/Audio";
#else
    public static string Folder => Application.dataPath + "/../Audio";
#endif


    private void Start()
    {
        Load();
    }

    private void Load()
    {
        clips.Clear();

        foreach (var file in Directory.GetFiles(Folder, "*.mp3", SearchOption.AllDirectories))
        {
            string name = Path.GetFileNameWithoutExtension(file);

            WWW www = new WWW(file);
            while (www.isDone == false) { }

            AudioClip clip = www.GetAudioClip(false, false);
            clips.Add(name, clip);
        }
    }
}
