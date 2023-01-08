using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RoutesLoader : MonoBehaviour
{
    public List<Route> routes = new();

#if UNITY_EDITOR
    public static string Folder => Application.dataPath + "/../Build/Routes";
#else
    public static string Folder => Application.dataPath + "/../Routes";
#endif

    private void Awake()
    {
        Load();
    }
    public void CreateNew()
    {
        Route route = new Route()
        {
            name = "Новый маршрут"
        };
        routes.Add(route);
        Save(route);
    }
    public void Remove(Route route)
    {
        routes.Remove(route);
        File.Delete(Folder + "/" + route.name + ".json");
    }
    public void Save(Route route)
    {
        string json = JsonUtility.ToJson(route, true);
        string filepath = Folder + "/" + route.name + ".json";
        File.WriteAllText(filepath, json);
    }
    public void Rename(Route route, string newName)
    {
        string oldPath = Folder + "/" + route.name + ".json";

        File.Delete(oldPath);
        route.name = newName;
        Save(route);
    }
    public bool CanRename(Route route, string newName) 
    {
        return File.Exists(Folder + "/" + newName + ".json") == false;
    }
    public void Load()
    {
        routes.Clear();

        Directory.CreateDirectory(Folder);
        foreach (var file in Directory.GetFiles(Folder, "*.json", SearchOption.AllDirectories))
        {
            string json = File.ReadAllText(file);
            Route route = JsonUtility.FromJson<Route>(json);
            routes.Add(route);
        }
    }
}