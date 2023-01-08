using InGame.UI;
using System.Linq;
using TMPro;
using UnityEngine;

public class RouteEditUI : MonoBehaviour
{
    [SerializeField] private RoutesUI routes;
    [SerializeField] private RoutesLoader loader;
    [SerializeField] private SelectWindow selectWindow;
    [SerializeField] private AudioLoader audioLoader;

    [SerializeField] private TMP_InputField name;
    [SerializeField] private Transform stationsContent;
    [SerializeField] private StationUIItem stationPrefab;
    [SerializeField] private AddButton addButtonPrefab;

    private Route route;

    public void Open(Route route)
    {
        this.route = route;

        gameObject.SetActive(true);

        name.text = route.name;

        Refresh();
    }
    public void Refresh()
    {
        UIHelper.Clear(stationsContent);
        UIHelper.Refresh(stationPrefab, stationsContent, route.stations, (lot, model) => lot.Refresh(this, route, model));

        AddButton inst = Instantiate(addButtonPrefab, stationsContent);
        inst.Refresh("Добавить станцию", AddNewStation);
    }
    public void OnNameChanged(string newName)
    {
        if (route.name != newName)
        {
            if (loader.CanRename(route, newName))
            {
                name.text = newName;
            }
            else
            {
                name.text = route.name;
            }
        }
    }
    public void Cancel()
    {
        gameObject.SetActive(false);
        loader.Load();
        routes.Refresh();
    }
    public void SaveRoute()
    {
        if (name.text != route.name)
        {
            loader.Rename(route, name.text);
        }

        loader.Save(route);

        Cancel();
    }
    public void ChangeAudio(Station station)
    {
        selectWindow.Show(audioLoader.clips.Select(s => s.Key), station.audioFileName, key =>
        {
            station.audioFileName = key;
            Refresh();
        });
    }
    private void AddNewStation()
    {
        route.stations.Add(new Station());
        Refresh();
    }
}
