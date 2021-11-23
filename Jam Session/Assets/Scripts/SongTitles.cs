using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTitles : MonoBehaviour
{
    [SerializeField]
    private TextAsset songTitles;

    public string CreateSongTitles()
    {
        string songTitle = null;
        string[] songTitleArray1 = TextAssetParser.Parse(songTitles);

        int numSongs = Random.Range(3, 7);
        for (int i = 0; i < numSongs; i++)
        {
            string selectedSongTitle = SelectFromStringArray.RandomSelect(songTitleArray1);
            songTitle += "\n" + selectedSongTitle;
            songTitle = GrammarsConverter.Convert(songTitle);
        }

        return songTitle;
    }

}
