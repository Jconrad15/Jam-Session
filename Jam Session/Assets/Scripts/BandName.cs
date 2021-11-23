using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandName : MonoBehaviour
{
    [SerializeField]
    private TextAsset bandName1;
    [SerializeField]
    private TextAsset bandName2;

    public string CreateBandName(string selectedGenre)
    {
        string bandName = null;

        string[] bandName1Array = TextAssetParser.Parse(bandName1);
        string selectedBandName1 = SelectFromStringArray.RandomSelect(bandName1Array);
        string[] bandName2Array = TextAssetParser.Parse(bandName2);
        string selectedBandName2 = SelectFromStringArray.RandomSelect(bandName2Array);

        bandName += selectedBandName1;
        bandName += " ";
        bandName += selectedBandName2;


        return bandName;
    }
}
