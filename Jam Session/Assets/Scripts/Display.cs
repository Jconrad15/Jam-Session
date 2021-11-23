using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Display : MonoBehaviour
{
    [SerializeField]
    private GameObject generator;

    [SerializeField]
    private TextMeshProUGUI GenreField;
    [SerializeField]
    private TextMeshProUGUI BandNameField;
    [SerializeField]
    private TextMeshProUGUI MusiciansField;
    [SerializeField]
    private TextMeshProUGUI SongsField;

    public void UpdateUI(string genre, string bandName, string musicians, string songs)
    {
        GenreField.SetText("Genre: " + "\n" + genre);
        BandNameField.SetText("Band Name: " + "\n" + bandName);
        MusiciansField.SetText("Musicians: " + "\n" + musicians);
        SongsField.SetText("Songs: " + songs);
    }

}
