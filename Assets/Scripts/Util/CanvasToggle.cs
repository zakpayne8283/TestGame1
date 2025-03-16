using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasToggle : MonoBehaviour
{
    [SerializeField] private Canvas canvasToToggle; // Assign the UI Canvas in the Inspector.
    [SerializeField] private string toggleText;     // The text to show on the button when it's open.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleCanvasVisibility()
    {
        // Toggle the current status
        canvasToToggle.gameObject.SetActive(!canvasToToggle.gameObject.activeSelf);

        // Get the current text
        string oldText = this.gameObject.GetComponentInChildren<TMP_Text>().text;

        // Switch to the new/old text
        this.gameObject.GetComponentInChildren<TMP_Text>().text = toggleText;

        // Save the old text as the next text to toggle to
        toggleText = oldText;
    }
}
