using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TownManager : MonoBehaviour
{
    public TMP_Text _townNameText;

    // List of UI buttons that require Town Data
    public Button _nextTownButton;

    public Town TownObject;

    void Start()
    {
        // Generate a new town on start up
        TownObject.GenerateNewTown();

        // Setup default UI values
        SetupTownUI();

        // Setup onClick listeners
        _nextTownButton.onClick.AddListener(UpdateTownInfo);

    }

    public void UpdateTownInfo()
    {
        TownObject.GenerateNewTown();
    }

    /// <summary>
    /// Called on Start() to setup the UI
    /// </summary>
    private void SetupTownUI()
    {
        // On start, setup the town information
        _townNameText.text = TownObject.TownName;
    }
}
