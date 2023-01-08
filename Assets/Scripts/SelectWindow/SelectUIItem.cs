using TMPro;
using UnityEngine;

public class SelectUIItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject selectIndicator;

    private SelectWindow window;

    public void Refresh(SelectWindow window, string text, bool isSelected)
    {
        this.window = window;
        this.text.text = text;
        selectIndicator.SetActive(isSelected);
    }
    public void OnClicked()
    {
        window.OnItemClicked(text.text);
    }
}