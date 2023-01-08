using InGame.UI;
using System.Collections.Generic;
using UnityEngine;

public class RoutesUI : MonoBehaviour
{
    [SerializeField] private RoutesLoader loader;
    [SerializeField] private RouteEditUI editUI;
    [SerializeField] private Transform content;
    [SerializeField] private RouteUIItem itemPrefab;
    [SerializeField] private AddButton addButtonPrefab;

    private void Start()
    {
        Refresh();
    }
    public void EditRoute(Route route)
    {
        editUI.Open(route);
    }
    public void RemoveRoute(Route route)
    {
        loader.Remove(route);
        Refresh();
    }
    private void AddNewRoute()
    {
        loader.CreateNew();
        Refresh();
    }
    public void Refresh()
    {
        UIHelper.Clear(content);
        UIHelper.Refresh(itemPrefab, content, loader.routes, (lot, route) => lot.Refresh(this, route));

        AddButton inst = Instantiate(addButtonPrefab, content);
        inst.Refresh("Новый маршрут", AddNewRoute);
    }
    public void Cancel()
    {
        gameObject.SetActive(false);
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
}
[System.Serializable]
public class Route
{
    public string name;
    public List<Station> stations = new List<Station>();
}
[System.Serializable]
public class Station
{
    public string name;
    public string audioFileName;
}
