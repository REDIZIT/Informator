using InApp;
using InGame.UI;
using System.Collections.Generic;
using UnityEngine;

public class KeysUI : MonoBehaviour
{
    [SerializeField] private KeyHooker hooker;
    [SerializeField] private Transform content;
    [SerializeField] private KeyUIItem item;

    public void Show()
    {
        gameObject.SetActive(true);

        UIHelper.Refresh(item, content, hooker.bindings.EnumerateBindings(), (lot, model) => lot.Refresh(this, hooker, model));
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
public class KeysBindings
{
    public KeyBinding playAudioAndGoNext = new KeyBinding("Проиграть звук и перейти к след. станции");
    public KeyBinding switchReverseMode = new KeyBinding("Переключить режим обратного маршрута");

    public IEnumerable<KeyBinding> EnumerateBindings()
    {
        yield return playAudioAndGoNext;
        yield return switchReverseMode;
    }
}

[System.Serializable]
public class KeyBinding
{
    public string description;
    public Keys key;

    public KeyBinding()
    {

    }
    public KeyBinding(string description)
    {
        this.description = description;
    }
}