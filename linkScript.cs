using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkScript : MonoBehaviour
{
    public void twitterLink()
    {
        Application.OpenURL("https://twitter.com/GamesVentus");
    }

    public void itchLink()
    {
        Application.OpenURL("https://ryanventus.itch.io/");
    }
}
