using TMPro;
using UnityEngine;

public class StationUIItem : MonoBehaviour
{
    [SerializeField] private TMP_InputField name;
    [SerializeField] private TextMeshProUGUI audioName, indexText;

    private RouteEditUI ui;
    private Route route;
    private Station station;

    public void Refresh(RouteEditUI ui, Route route, Station station)
    {
        this.ui = ui;
        this.route = route;
        this.station = station;

        name.text = station.name;
        audioName.text = station.audioFileName;
        indexText.text = (route.stations.IndexOf(station) + 1).ToString();
    }
    public void OnNameChanged(string newName)
    {
        station.name = newName;
    }
    public void OnMoveUpClicked()
    {
        int index = route.stations.IndexOf(station);
        if (index > 0)
        {
            route.stations.RemoveAt(index);
            index--;
            route.stations.Insert(index, station);
        }

        ui.Refresh();
    }
    public void OnMoveDownClicked()
    {
        int index = route.stations.IndexOf(station);
        if (index < route.stations.Count - 1)
        {
            route.stations.RemoveAt(index);
            index++;
            route.stations.Insert(index, station);
        }

        ui.Refresh();
    }
    public void OnDeleteClicked()
    {
        route.stations.Remove(station);

        ui.Refresh();
    }
    public void OnChangeAudioClicked()
    {
        ui.ChangeAudio(station);
    }
}
