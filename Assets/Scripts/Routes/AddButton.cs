using System;
using TMPro;
using UnityEngine;

public class AddButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private Action callback;

    public void Refresh(string text, Action callback)
    {
        this.callback = callback;
        this.text.text = text;
    }
    public void OnClick()
    {
        callback?.Invoke();
    }
}
