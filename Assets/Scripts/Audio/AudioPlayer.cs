using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private AudioLoader loader;
    [SerializeField] private AudioSource source;

    private float volume = 0.5f;

    public void Play(string audioFilename)
    {
        if (loader.clips.TryGetValue(audioFilename, out AudioClip clip))
        {
            source.clip = clip;
            source.Play();
        }
        else
        {
            Debug.LogError("No audio file found '" + audioFilename + "'");
        }
    }
    public void SetVolume(float volume)
    {
        this.volume = volume;
        source.volume = volume;
    }
}