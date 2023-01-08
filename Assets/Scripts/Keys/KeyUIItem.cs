using InApp;
using TMPro;
using UnityEngine;

public class KeyUIItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI description, keyText;

    private KeysUI ui;
    private KeyHooker hooker;
    private KeyBinding binding;

    private void Update()
    {
        keyText.text = binding.key.ToString();
    }

    public void Refresh(KeysUI ui, KeyHooker hooker, KeyBinding binding)
    {
        this.ui = ui;
        this.hooker = hooker;
        this.binding = binding;

        description.text = binding.description;
    }
    public void OnChangeKeyClick()
    {
        hooker.InvokeKeyChanging(OnKeyPressed);
    }
    public void OnResetClicked()
    {
        binding.key = Keys.None;
        hooker.Save();
    }
    private void OnKeyPressed(Keys key)
    {
        if (key != Keys.Escape)
        {
            binding.key = key;
            hooker.Save();
        }
    }
}
