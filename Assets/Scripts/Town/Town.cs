using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Town", menuName = "Scriptable Objects/Town")]
public class Town : ScriptableObject
{
    public event Action OnTownUpdated; // Event for notifying changes

    [SerializeField] private string townName;
    [SerializeField] private string townDescription;
    [SerializeField] private Sprite townImage;
    [SerializeField] private Sprite[] availableImages;

    public string TownName
    {
        get => townName;
        set
        {
            if (townName != value)
            {
                townName = value;
                OnTownUpdated?.Invoke(); // Notify listeners
            }
        }
    }

    public string TownDescription
    {
        get => townDescription;
        set
        {
            if (townDescription != value)
            {
                townDescription = value;
            }
        }
    }

    public Sprite TownImage
    {
        get => townImage;
        set
        {
            if (townImage != value)
            {
                townImage = value;
            }
        }
    }

    public void GenerateNewTown()
    {
        this.TownName = GenerateRandomName(5);
        this.TownDescription = GenerateRandomName(100);
        this.SetRandomTownImage();
        
        OnTownUpdated?.Invoke();
    }

    public static string GenerateRandomName(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        System.Random random = new System.Random();
        char[] result = new char[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = chars[random.Next(chars.Length)];
        }

        return new string(result);
    }

    private void SetRandomTownImage()
    {
        if (this.availableImages != null && this.availableImages.Length > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, this.availableImages.Length);
            this.TownImage = this.availableImages[randomIndex];
        }
    }
}
