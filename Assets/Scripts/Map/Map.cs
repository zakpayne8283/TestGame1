using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    // Button that triggers the map to open or close.
    public Button _viewMapButton;

    // The Map canvas that will flyout
    public Canvas _MapFlyout;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// On "Town Description" click, show flyout menu with town details
    /// </summary>
    public void toggleViewMap()
    {
        bool isActive = _MapFlyout.gameObject.activeSelf;

        // If not displayed, display and change button text.
        if (!isActive)
        {
            _MapFlyout.GetComponentInChildren<TMP_Text>().text = "Close Map";
        }
        else
        {
            _MapFlyout.GetComponentInChildren<TMP_Text>().text = "View Map";
        }

        _MapFlyout.gameObject.SetActive(!isActive);
    }
}
