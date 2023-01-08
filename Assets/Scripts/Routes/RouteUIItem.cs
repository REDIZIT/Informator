using TMPro;
using UnityEngine;

public class RouteUIItem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI name, path;

    private RoutesUI ui;
    private Route route;

    private void Update()
    {
        name.text = route.name;
        path.text = RoutesLoader.Folder + "/" + route.name + ".json";
    }
    public void Refresh(RoutesUI ui, Route route)
    {
        this.ui = ui;
        this.route = route;
    }
    public void OnClick()
    {
        ui.EditRoute(route);
    }
    public void OnDeleteClicked()
    {
        ui.RemoveRoute(route);
    }
}
