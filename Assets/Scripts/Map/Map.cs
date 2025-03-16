using UnityEngine;

[CreateAssetMenu(fileName = "Map", menuName = "Scriptable Objects/Map")]
public class Map : ScriptableObject
{
    public Location currentLocation;

    public static Map CreateInitialMap()
    {
        Map output = new Map();

        Debug.Log("Creating initial map");

        return output;
    }
}
