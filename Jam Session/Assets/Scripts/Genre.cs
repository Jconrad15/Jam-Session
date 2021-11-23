using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genre : MonoBehaviour
{
    public string CreateGenre()
    {
        GenreEnums.GenreEnum selectedEnum = (GenreEnums.GenreEnum)Random.Range(0, 13);
        string selected = selectedEnum.ToString();
        return selected;
    }
}
