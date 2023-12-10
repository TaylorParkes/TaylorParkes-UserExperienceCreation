using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help_Button : MonoBehaviour
{
    // Need Help Button takes player to Google
    public void OpenURL()
    {
        Application.OpenURL("https://www.google.co.uk/");
        Debug.Log("Google has Opened");
    }
}
