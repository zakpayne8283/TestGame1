using UnityEngine;

[CreateAssetMenu(fileName = "Location", menuName = "Scriptable Objects/Location")]
public class Location : ScriptableObject
{
    public Location north;
    public Location northeast;
    public Location east;
    public Location southeast;
    public Location south;
    public Location southwest;
    public Location west;
    public Location northwest;

    public VISIBILITY_STATUS visibilityStatus = VISIBILITY_STATUS.DEFAULT;

    public void GenerateFirstLocation()
    {
        this.visibilityStatus = VISIBILITY_STATUS.EXPLORED;

        this.north = InitializeAdjacentLocation(VISIBILITY_STATUS.LIGHT_FOG);
    }

    private static Location InitializeAdjacentLocation(VISIBILITY_STATUS visibility)
    {
        Location output = ScriptableObject.CreateInstance<Location>();
        output.visibilityStatus = visibility;

        if (visibility == VISIBILITY_STATUS.LIGHT_FOG)
        {
            // Initialize all adjacent locations with heavy fog if needed
        }

        return output;
    }
}

public enum VISIBILITY_STATUS
{
    EXPLORED,
    LIGHT_FOG,
    HEAVY_FOG,
    DEFAULT
}
