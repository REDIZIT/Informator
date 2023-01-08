using InGame.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class SelectWindow : MonoBehaviour
{
    [SerializeField] private TMP_InputField search;
    [SerializeField] private Transform content;
    [SerializeField] private SelectUIItem prefab;

    private string selectedItem;
    private IEnumerable<string> allItems;
    private Action<string> callback;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Close();
        }
    }
    public void Show(IEnumerable<string> items, string selectedItem, Action<string> callback)
    {
        this.allItems = items;
        this.selectedItem = selectedItem;
        this.callback = callback;

        gameObject.SetActive(true);

        Refresh(items);

        search.ActivateInputField();
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    public void OnSearchEdit(string searchText)
    {
        Refresh(allItems.Where(i => i.Contains(searchText)));
    }
    public void OnItemClicked(string text)
    {
        callback?.Invoke(text);
        Close();
    }

    private void Refresh(IEnumerable<string> items)
    {
        UIHelper.Refresh(prefab, content, items, (lot, model) => lot.Refresh(this, model, model == selectedItem));
    }
}
