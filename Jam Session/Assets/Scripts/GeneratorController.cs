using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    [SerializeField]
    private Display display;
    
    [SerializeField]
    private Genre genreCreator;
    [SerializeField]
    private BandName bandNameCreator;
    [SerializeField]
    private musicianNames musicianCreator;
    [SerializeField]
    private SongTitles songTitleCreator;

    private string selectedGenre;
    private string selectedBandName;
    private string selectedMusicians;
    private string selectedSongs;


    void Awake()
    {
        StartABand();
        display.UpdateUI(selectedGenre, selectedBandName, selectedMusicians, selectedSongs);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartABand();
            display.UpdateUI(selectedGenre, selectedBandName, selectedMusicians, selectedSongs);

        }
    }

    private void StartABand()
    {
        selectedGenre = genreCreator.CreateGenre();
        selectedBandName = bandNameCreator.CreateBandName(selectedGenre);
        selectedMusicians = musicianCreator.CreateMusicianNames();
        selectedSongs = songTitleCreator.CreateSongTitles();
    }
}
