using InApp;
using System.Diagnostics;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RouteState : MonoBehaviour
{
    [SerializeField] private RoutesLoader loader;
    [SerializeField] private KeyHooker hooker;
    [SerializeField] private new AudioPlayer audio;
    [SerializeField] private SelectWindow selectWindow;

    [Space(20)]
    [SerializeField] private TextMeshProUGUI routeName;
    [SerializeField] private TextMeshProUGUI current, prev, next;

    [SerializeField] private Image reverseIcon;
    [SerializeField] private Outline reverseOutline;
    [SerializeField] private TextMeshProUGUI reverseText;
    [SerializeField] private Color reverseDisabled, reverseEnabled;
    [SerializeField] private Color reverseOutlineDisabled, reverseOutlineEnabled;

    private int Direction => isReversed ? -1 : 1;

    private bool isReversed;
    private int currentStation;
    private Route route;

    private void Start()
    {
        if (loader.routes.Count > 0)
        {
            ChangeRoute(loader.routes.First());
        }

        hooker.onKeyPressed += OnKeyPressed;
    }
    private void Update()
    {
        RefreshStations();
        RefreshReverse();
    }
    private void OnDestroy()
    {
        hooker.onKeyPressed -= OnKeyPressed;
    }


    public void ChangeRoute(Route route)
    {
        this.route = route;

        routeName.text = route.name;
        isReversed = false;
    }
    public void OnReverseClicked()
    {
        isReversed = !isReversed;
    }
    public void OnRouteClicked()
    {
        selectWindow.Show(loader.routes.Select(r => r.name), route == null ? "" : route.name, name =>
        {
            ChangeRoute(loader.routes.First(r => r.name == name));
        });
    }
    public void SetVolume(float volume)
    {
        audio.SetVolume(volume);
    }
    public void OpenRoutesFolder()
    {
        OpenFolder(RoutesLoader.Folder);
    }
    public void OpenAudioFolder()
    {
        OpenFolder(AudioLoader.Folder);
    }

    private void OpenFolder(string path)
    {
        Process.Start(path);
    }
    private void RefreshStations()
    {
        int nextIndex = currentStation + Direction;
        int prevIndex = currentStation - Direction;

        RefreshStationText(current, currentStation);
        RefreshStationText(next, nextIndex);
        RefreshStationText(prev, prevIndex);
    }
    private void RefreshStationText(TextMeshProUGUI text, int index)
    {
        if (route == null || index < 0 || index >= route.stations.Count)
        {
            text.text = "-";
        }
        else
        {
            text.text = route.stations[index].name;
        }
    }
    private void RefreshReverse()
    {
        if (isReversed)
        {
            reverseText.text = "Выключить обратный маршрут";
            reverseIcon.color = reverseEnabled;
            reverseOutline.effectColor = reverseOutlineEnabled;
        }
        else
        {
            reverseText.text = "Включить обратный маршрут";
            reverseIcon.color = reverseDisabled;
            reverseOutline.effectColor = reverseOutlineDisabled;
        }
    }


    private void OnKeyPressed(Keys key)
    {
        if (key == Keys.None) return;

        if (key == hooker.bindings.playAudioAndGoNext.key)
        {
            PlaySoundAndGoNext();
        }
        else if (key == hooker.bindings.switchReverseMode.key)
        {
            OnReverseClicked();
        }
    }
    private void PlaySoundAndGoNext()
    {
        if (route == null || currentStation >= route.stations.Count) return;

        Station station = route.stations[currentStation];

        audio.Play(station.audioFileName);


        int nextStationIndex = currentStation + Direction;
        if (nextStationIndex >= 0 && nextStationIndex < route.stations.Count)
        {
            currentStation = nextStationIndex;
        }
    }
}
