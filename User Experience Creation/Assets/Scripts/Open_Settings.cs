using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Settings : MonoBehaviour
{
    // Opening Menu PopUps
    public GameObject OpenMenu;
    
    public void OpenPopUp()
    {
        if (OpenMenu.activeInHierarchy == false)
        OpenMenu.SetActive(true);
    } 
}