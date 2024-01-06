using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menu1Panel;
    public GameObject menu2Panel;
    public GameObject menu3Panel;

    public void ShowMenu1()
    {
        menu1Panel.SetActive(true);
        menu2Panel.SetActive(false);
        menu3Panel.SetActive(false);
    }

    public void ShowMenu2()
    {
        menu1Panel.SetActive(false);
        menu2Panel.SetActive(true);
        menu3Panel.SetActive(false);
    }

    public void ShowMenu3()
    {
        menu1Panel.SetActive(false);
        menu2Panel.SetActive(false);
        menu3Panel.SetActive(true);
    }
}
