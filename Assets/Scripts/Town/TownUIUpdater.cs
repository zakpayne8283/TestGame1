using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum AVAILABLE_TOWN_INFO
{
    TOWN_NAME,
    TOWN_DESCRIPTION,
    TOWN_IMAGE
}

public class TownUIUpdater : MonoBehaviour
{
    public Town TownObject;

    public AVAILABLE_TOWN_INFO UpdateTo;

    private TMP_Text textElement;

    private Image imageElement;

    void Start()
    {
        textElement = GetComponent<TMP_Text>();
        imageElement = GetComponent<Image>();
        TownObject.OnTownUpdated += UpdateUIElement; // Subscribe to the event
        UpdateUIElement(); // Initialize with the current name
    }

    void OnDestroy()
    {
        TownObject.OnTownUpdated -= UpdateUIElement; // Unsubscribe to avoid memory leaks
    }

    private void UpdateUIElement()
    {
        if (
            UpdateTo == AVAILABLE_TOWN_INFO.TOWN_NAME ||
            UpdateTo == AVAILABLE_TOWN_INFO.TOWN_DESCRIPTION
        )
        {
            // Update the text-based fields.
            string newText;

            switch (UpdateTo)
            {
                case AVAILABLE_TOWN_INFO.TOWN_NAME:
                    newText = TownObject.TownName;
                    break;
                case AVAILABLE_TOWN_INFO.TOWN_DESCRIPTION:
                    newText = TownObject.TownDescription;
                    break;
                default:
                    newText = "Error";
                    break;
            }

            textElement.text = newText;
        }
        else if (UpdateTo == AVAILABLE_TOWN_INFO.TOWN_IMAGE)
        {
            imageElement.sprite = TownObject.TownImage;
        }
    }
}
