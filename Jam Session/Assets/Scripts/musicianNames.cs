using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicianNames : MonoBehaviour
{
    [SerializeField]
    private TextAsset firstName;
    [SerializeField]
    private TextAsset lastName;

    [SerializeField]
    private TextAsset lastNameConstructor1;
    [SerializeField]
    private TextAsset lastNameConstructor2;

    public string CreateMusicianNames()
    {
        string names = null;
        int numMusicians = Random.Range(1, 5);

        string[] firstNameArray = TextAssetParser.Parse(firstName);
        string[] lastNameArray = TextAssetParser.Parse(lastName);
        string[] lastNameConstructor1Array = TextAssetParser.Parse(lastNameConstructor1);
        string[] lastNameConstructor2Array = TextAssetParser.Parse(lastNameConstructor2);

        for (int i = 0; i < numMusicians; i++)
        {
            string selectedFirstName = SelectFromStringArray.RandomSelect(firstNameArray);
            string selectedLastName = null;

            if (Random.value > 0.2f)
            {
                selectedLastName = SelectFromStringArray.RandomSelect(lastNameArray);
            }
            else
            {
                string constructedName = null;
                constructedName += SelectFromStringArray.RandomSelect(lastNameConstructor1Array);
                constructedName += SelectFromStringArray.RandomSelect(lastNameConstructor2Array);

                selectedLastName = constructedName;
            }
            names = names + selectedFirstName + " " + selectedLastName + "\n";
        }
        return names;
    }
}
